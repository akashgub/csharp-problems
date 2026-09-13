Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine()); // int a = 15

for (int i = 1; i <= 10; i++)
{
    int ans = number * i;
    Console.WriteLine(number + " x " + i + " = " + ans);
}
