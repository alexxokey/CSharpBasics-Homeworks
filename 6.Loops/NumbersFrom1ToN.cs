using System;
class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int n = 1;
        while (n <= number)
        {
            Console.WriteLine(n);
            n++;
        }
    }
}

