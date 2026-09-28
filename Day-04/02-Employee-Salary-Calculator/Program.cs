class Employee
{
    public string Name{get; set;}
    public string Position{get; set;}
    public double MonthlySalary{get; set;}

    // constructor
    public Employee(string name, string position, double monthlySalary){
        Name = name;
        Position = position;
        MonthlySalary = monthlySalary;
    }
    // calculate annual salary
    public double CalculateAnnualSalary()
    {
        return MonthlySalary * 12;
    }
    //display employee information
    public void DisplayInfo(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Monthly Salary: {MonthlySalary}");
        Console.WriteLine($"Annual Salary: {CalculateAnnualSalary()}");
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee(
            "Akash",
            "Junior Software Engineer",
            25000
        );

        Employee employee2 = new Employee(
            "Rahim",
            "Backend Developer",
            30000
        );

        Employee employee3 = new Employee(
            "Karim",
            "Software Engineer",
            40000
        );

        employee1.DisplayInfo();
        employee2.DisplayInfo();
        employee3.DisplayInfo();
    }
}