// ============================================================
// ClassVsObjectDemo
// A short live-coding demo for the "Class vs. Object" micro-teach.
// ============================================================


using System.Text;

class Program
{
    // ---- MAIN: the entry point where the program starts running ----
    static void Main(string[] args)
    {

        // ===== BEFORE: Without Classes =====
        // Data and functions are kept apart.
        // Every cake needs its own separate variables AND its own separate function.

        int cake1Flour = 200;
        int cake1Sugar = 150;
        int cake1Eggs = 2;

        int cake2Flour = 300;
        int cake2Sugar = 250;
        int cake2Eggs = 3;

        int cake3Flour =250;
        int cake3Sugar = 200;
        int cake3Eggs = 2;
        // if you have 100 cakes, you would need 100 sets of variables and 100 functions. This is not scalable.your code will be very long and hard to maintain. This is where classes and objects come in.

        Console.WriteLine($"BEFORE: Without Classes.");

        void BakeCake1()
        {
            Console.WriteLine($"Baking with {cake1Flour}, {cake1Sugar}, {cake1Eggs} eggs.");
        }

        void BakeCake2()
        {
            Console.WriteLine($"Baking with {cake2Flour}, {cake2Sugar}, {cake2Eggs} eggs.");
        }

        void BakeCake3()
        {
            Console.WriteLine($"Baking with {cake3Flour}, {cake3Sugar}, {cake3Eggs} eggs.");
        }

        BakeCake1();
        BakeCake2();
        BakeCake3();
        Console.WriteLine();

        // ===== AFTER: Using Class & Object =====
       Console.WriteLine($"AFTER: Using Class & Object.");
       
        Cake cake1 = new Cake(200, 150, 2);
        cake1.Bake();

        Cake cake2 = new Cake(300, 250, 3);
        cake2.Bake();

        Cake cake3 = new Cake(250, 200, 2);
        cake3.Bake();
    }


   
}

// ============================================================
// THE CLASS = THE RECIPE
// ============================================================

public class Cake
{
    //1- Fields — the data of the cake
    public int Flour;
    public int Sugar;
    public int Eggs;
    // 2Constructor —  runs when we create a new object and sets its initial values
    public Cake(int flour, int sugar, int eggs)
    {
        Flour = flour;
        Sugar = sugar;
        Eggs = eggs;
    }

    // 3- Method — an instruction from the recipe
    public void Bake()
    {
        Console.WriteLine($"Baking with {Flour}, {Sugar}, {Eggs} eggs.");
    }
}

