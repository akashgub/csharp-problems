class Student
{
    public string Name{get; set;}
    public int Age{get; set;}
    public string Department{get; set;}
    public double CGPA{get; set;}

    public void DisplayInfo(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"CGPA: {CGPA}");
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();

        student1.Name = "Akash";
        student1.Age = 24;
        student1.Department = "CSE";
        student1.CGPA = 3.30;

        Student student2 = new Student();

        student2.Name = "Karim";
        student2.Age = 25;
        student2.Department = "SWE";
        student2.CGPA = 3.60;

        Student student3 = new Student();

        student3.Name = "Rahim";
        student3.Age = 28;
        student3.Department = "BBA";
        student3.CGPA = 3.40;

        student1.DisplayInfo();
        student2.DisplayInfo();
        student3.DisplayInfo();

    }
}