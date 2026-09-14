Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

 int count = 0;
for (int i = 1; i <= N; i++)
{
    if (i % 2 != 0)
    {
        count++;
    }
}
Console.WriteLine("Count of odd numbers = " + count);