abstract class Payment
{
    public string CustomerName { get; set; }
    public double Amount { get; set; }

    // Abstract method
    public abstract void Pay();
}


interface IReceipt
{
    void GenerateReceipt();
}


class BkashPayment : Payment, IReceipt
{
    public BkashPayment(string customerName, double amount)
    {
        CustomerName = customerName;
        Amount = amount;
    }

    public override void Pay()
    {
        Console.WriteLine(
            $"{CustomerName} paid {Amount} using bKash."
        );
    }

    public void GenerateReceipt()
    {
        Console.WriteLine(
            $"bKash receipt generated for {CustomerName}."
        );
    }
}


class CardPayment : Payment, IReceipt
{
    public CardPayment(string customerName, double amount)
    {
        CustomerName = customerName;
        Amount = amount;
    }

    public override void Pay()
    {
        Console.WriteLine(
            $"{CustomerName} paid {Amount} using Card."
        );
    }

    public void GenerateReceipt()
    {
        Console.WriteLine(
            $"Card receipt generated for {CustomerName}."
        );
    }
}


class CashPayment : Payment, IReceipt
{
    public CashPayment(string customerName, double amount)
    {
        CustomerName = customerName;
        Amount = amount;
    }

    public override void Pay()
    {
        Console.WriteLine(
            $"{CustomerName} paid {Amount} using Cash."
        );
    }

    public void GenerateReceipt()
    {
        Console.WriteLine(
            $"Cash receipt generated for {CustomerName}."
        );
    }
}


class Program
{
    static void Main(string[] args)
    {
        Payment payment1 = new BkashPayment(
            "Akash",
            500
        );

        Payment payment2 = new CardPayment(
            "Rahim",
            1000
        );

        Payment payment3 = new CashPayment(
            "Karim",
            300
        );

        payment1.Pay();
        ((IReceipt)payment1).GenerateReceipt();

        Console.WriteLine();

        payment2.Pay();
        ((IReceipt)payment2).GenerateReceipt();

        Console.WriteLine();

        payment3.Pay();
        ((IReceipt)payment3).GenerateReceipt();
    }
}