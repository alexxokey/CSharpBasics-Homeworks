using System;
class NumbersInIntervalDividable
{
    static void Main()
    {
        Console.Write("Enter the first positive integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second positive integer: ");
        int b = int.Parse(Console.ReadLine());
        for (int i = a; i < b; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }

        }
    }
}

