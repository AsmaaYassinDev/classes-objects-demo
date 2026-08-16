// ============================================================
// ClassVsObjectDemo
// A short live-coding demo for the "Class vs. Object" micro-teach.
// ============================================================


class Program
{
    // ---- MAIN: the entry point where the program starts running ----
    static void Main(string[] args)
    {

        // ===== BEFORE: Without Classes =====
        // Data and functions are kept apart.
        // Every cake needs its own separate variables AND its own separate function.

        string cake1Flour = "200g";
        string cake1Sugar = "150g";
        int cake1Eggs = 2;

        string cake2Flour = "300g";
        string cake2Sugar = "250g";
        int cake2Eggs = 3;

        void BakeCake1()
        {
            Console.WriteLine($"Baking with {cake1Flour}, {cake1Sugar}, {cake1Eggs} eggs.");
        }

        void BakeCake2()
        {
            Console.WriteLine($"Baking with {cake2Flour}, {cake2Sugar}, {cake2Eggs} eggs.");
        }

        BakeCake1();
        BakeCake2();
        // ===== AFTER: Using Class & Object =====
        // One class. Each object keeps its own data and actions together.

        Cake cake1 = new Cake(200, 150, 2);
        cake1.Bake();

        Cake cake2 = new Cake(300, 250, 3);
        cake2.Bake();
    }


   
}

// ============================================================
// THE CLASS = THE RECIPE
// ============================================================
class Cake
{
    // Fields — the data of the cake
    public int Flour;   // grams
    public int Sugar;   // grams
    public int Eggs;

    // Constructor — runs when we create a new object
    public Cake(int flour, int sugar, int eggs)
    {
        Flour = flour;
        Sugar = sugar;
        Eggs = eggs;
    }

    // Method — an instruction from the recipe
    public void Bake()
    {
        Console.WriteLine($"Baking a cake with {Flour}g flour, {Sugar}g sugar, {Eggs} eggs.");
    }
}
