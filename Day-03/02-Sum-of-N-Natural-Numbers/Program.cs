Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= N; i++)
{
    sum += i;
}
Console.WriteLine("Sum = " + sum);

