class Employee
{
    public string Name { get; set; }

    private double salary;

    public Employee(string name, double salary)
    {
        Name = name;
        this.salary = salary;
    }

    public void UpdateSalary(double newSalary)
    {
        if (newSalary > 0)
        {
            salary = newSalary;
        }
        else
        {
            Console.WriteLine("Invalid salary!");
        }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Salary: {salary}");
    }
}

class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, double salary, int teamSize)
        : base(name, salary)
    {
        TeamSize = teamSize;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Manager Name: {Name}");

        base.DisplayInfo();

        Console.WriteLine($"Team Size: {TeamSize}");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Akash", 30000);

        employee.DisplayInfo();

        Console.WriteLine();

        employee.UpdateSalary(35000);

        Console.WriteLine("After Salary Update:");
        
        employee.DisplayInfo();

        Console.WriteLine();

        Manager manager = new Manager("Rahim", 60000, 5);

        manager.DisplayInfo();
    }
}
