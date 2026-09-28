class BankAccount
{
    public string AccountHolder{get; set;}
    public string AccountNumber{get; set;}

    private double Balance{get; set;}

    //construtor
    public BankAccount(string accountHolder, string accountNumber, double initialBalance)
    {
        AccountHolder = accountHolder;
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }
    //deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
        }
    }
    //Withdraw money
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than 0.");
        }
        else if(amount > Balance)
        {
            Console.WriteLine("Insufficient Balance.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdraw: {amount}");
        }
    }
    //get current balance
    public double GetBalance()
    {
        return Balance;
    }
    //Display account information
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Current Balance: {Balance}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount(
            "Akash",
            "1001",
            5000
        );
        Console.WriteLine();
        account1.DisplayAccountInfo();

        account1.Deposit(2000);
        account1.Withdraw(1500);

        Console.WriteLine($"Current Balance: {account1.GetBalance()}");

        Console.WriteLine();
        BankAccount account2 = new BankAccount(
            "Rahim",
            "1002",
            10000
        );
        Console.WriteLine();
        account2.DisplayAccountInfo();

        account2.Deposit(3000);
        account2.Withdraw(1800);

        Console.WriteLine($"Current Balance: {account2.GetBalance()}");
    }
}