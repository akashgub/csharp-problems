interface IPayment
{
    void Pay();
    void GenerateReceipt();
}

class BkashPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Akash paid 500 using bKash");
    }
    public void GenerateReceipt()
    {
        Console.WriteLine("bKash receipt generated for Akash");
    }
}
class CardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Rahim paid 1000 using Card");
    }
    public void GenerateReceipt()
    {
        Console.WriteLine("Card receipt generated for Rahim");
    }
}
class Program
{
    static void Main()
    {
        IPayment payment1 = new BkashPayment();

        payment1.Pay();
        payment1.GenerateReceipt();

        Console.WriteLine();

        IPayment payment2 = new CardPayment();
        payment2.Pay();
        payment2.GenerateReceipt();

    }
}