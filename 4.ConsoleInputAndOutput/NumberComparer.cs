using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter the fisrt number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        bool agreaterthanb = a > b;
        Console.WriteLine("The fisrt number is greater than the second: {0}!", agreaterthanb);
    }
}

