abstract class Employee
{
    public string Name { get; set; }

    public double Salary { get; set; }

    public abstract void Work();
}

class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine($"{Name} is developing software.");
    }
}

class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine($"{Name} is managing the team.");
    }
}

class Program
{
    static void Main()
    {
        Employee developer = new Developer();

        developer.Name = "Akash";
        developer.Salary = 40000;

        Console.WriteLine($"Developer: {developer.Name}");
        Console.WriteLine($"Salary: {developer.Salary}");

        developer.Work();

        Console.WriteLine();

        Employee manager = new Manager();

        manager.Name = "Rahim";
        manager.Salary = 60000;

        Console.WriteLine($"Manager: {manager.Name}");
        Console.WriteLine($"Salary: {manager.Salary}");

        manager.Work();
    }
}