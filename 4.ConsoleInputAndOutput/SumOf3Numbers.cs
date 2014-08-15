using System;
class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write the third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the numbers {0}, {1} and {2} is: {3}", a, b, c, a + b + c);
    }
}

