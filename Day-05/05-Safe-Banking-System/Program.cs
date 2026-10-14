class BankAccount
{
    public double? Balance { get; private set; }

    public BankAccount(double? initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(
                "Deposit amount must be greater than zero.");
        }

        if (Balance == null)
        {
            throw new InvalidOperationException(
                "Account balance is not available.");
        }

        Balance += amount;

        Console.WriteLine($"Deposited: {amount}");
        Console.WriteLine($"Current Balance: {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(
                "Withdraw amount must be greater than zero.");
        }

        if (Balance == null)
        {
            throw new InvalidOperationException(
                "Account balance is not available.");
        }

        if (amount > Balance.Value)
        {
            throw new InvalidOperationException(
                "Insufficient balance!");
        }

        Balance -= amount;

        Console.WriteLine($"Withdrawn: {amount}");
        Console.WriteLine($"Current Balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(10000);

        Console.WriteLine($"Initial Balance: {account.Balance}");
        Console.WriteLine();

        try
        {
            account.Deposit(2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine();

        try
        {
            account.Withdraw(3000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine();

        try
        {
            account.Withdraw(20000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine();

        try
        {
            account.Deposit(-500);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine($"Final Balance: {account.Balance}");
    }
}
