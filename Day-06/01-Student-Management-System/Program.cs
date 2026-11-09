using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student(101, "Akash", 85),
            new Student(102, "Rahim", 72),
            new Student(103, "Nusrat", 92),
            new Student(104, "Karim", 65),
            new Student(105, "Sadia", 88)
        };

        // Display all students
        Console.WriteLine("=== All Students ===");

        foreach (Student student in students)
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Marks}");
        }

        // 2. Find students with marks >= 80
        Console.WriteLine("\n=== Students with Marks >= 80 ===");

        var qualifiedStudents = students.Where(student => student.Marks >= 80);
        
        foreach (Student student in qualifiedStudents)
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Marks}");
        }

        // 3. Find top student 
        Console.WriteLine("\n=== Top Student ===");

        var topStudent = students.OrderByDescending(student => student.Marks).First();

        Console.WriteLine($"{topStudent.Id} - {topStudent.Name} - {topStudent.Marks}");

        Console.WriteLine($"Congratulations {topStudent.Name}!");

        // 4. Find Lowest student
        Console.WriteLine("\n=== Lowest Student ===");
        
        var lowestStudent = students.OrderBy(student => student.Marks).First();

        Console.WriteLine($"{lowestStudent.Id} - {lowestStudent.Name} - {lowestStudent.Marks}");
        Console.WriteLine($"Keep trying {lowestStudent.Name}! Better luck next time.");

        // 5. Count total students
        Console.WriteLine("\n=== Total Students ===");

        int totalStudents = students.Count();
        Console.WriteLine($"Total Students: {totalStudents}");
    }
}
