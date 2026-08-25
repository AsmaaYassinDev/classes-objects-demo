// ============================================================
// ClassVsObjectDemo
// A short live-coding demo for the "Class vs. Object" micro-teach.
// ============================================================

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Classes and Objects Exercise\n");

        // 1. Create the objects (just like creating a new Cake)
        BankAccount account1 = new BankAccount("001", "Sarah", 600);
        BankAccount account2 = new BankAccount("002", "John", 1000);

        // 2. Do the actions (just like calling cake1.Bake() )
        account1.Deposit(200);
        account2.Withdraw(300);

        // 3. Print the results to prove each object has its own data
        Console.WriteLine("Sarah's Balance is: " + account1.GetBalance());
        Console.WriteLine("John's Balance is: " + account2.GetBalance());
    }
}

// ==========================================
// BankAccount Class (The Blueprint)
// ==========================================
public class BankAccount
{
    // Fields (The Data)
    public string AccountNumber;
    public string OwnerName;
    public int Balance;

    // Constructor (The Setup when a new object is created)
    public BankAccount(string accountNumber, string ownerName, int initialBalance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = initialBalance;
    }

    // Methods (The Actions)
    public void Deposit(int amount)
    {
        Balance = Balance + amount;
    }

    public void Withdraw(int amount)
    {
        Balance = Balance - amount;
    }

    public int GetBalance()
    {
        return Balance;
    }
}