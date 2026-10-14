class StudentResult
{
    public static int CalculateTotal(int bangla, int english, int math)
    {
        return bangla + english + math;
    }

    public static double CalculateAverage(int total)
    {
        return total / 3.0;
    }

    public static string GetResult(double average)
    {
        if(average >= 40)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }
}

class Program
{
    static void Main()
    {
        string studentName = "Akash";

        int bangla = 75;
        int english = 85;
        int math = 91;

        int total = StudentResult.CalculateTotal(
            bangla, english, math);

        double average = StudentResult.CalculateAverage(total);
        string result = StudentResult.GetResult(average);

        Console.WriteLine($"Student: {studentName}");
        Console.WriteLine($"Bangla: {bangla}");
        Console.WriteLine($"English: {english}");
        Console.WriteLine($"Math: {math}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Result: {result}");
    }
}
