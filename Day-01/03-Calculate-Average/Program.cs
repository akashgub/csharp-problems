Console.Write("Enter your first number: ");
int a = Convert.ToInt32(Console.ReadLine()); //int a = 15

Console.Write("Enter your second number: ");
int b = Convert.ToInt32(Console.ReadLine()); // int b = 25

Console.Write("Enter your third number: ");
int c = Convert.ToInt32(Console.ReadLine()); // int c = 35

double average = (a + b + c) / 3.0;

Console.WriteLine("The average of " + a + ", " + b + ", and " + c + " is: " + average);
