Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine(number + " is a positive number.");
}
else if (number < 0)
{
    Console.WriteLine(number + " is a negative number.");
}
else
{
    Console.WriteLine("The number is zero.");
}
