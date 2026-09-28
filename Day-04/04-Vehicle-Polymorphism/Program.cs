class  Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting.");
    }
}

class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting.");
    }
}

class Bus : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bus is starting.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Car();
        Vehicle vehicle2 = new Bike();
        Vehicle vehicle3 = new Bus();

        vehicle1.Start();
        vehicle2.Start();
        vehicle3.Start();
    }
}