using System;
class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a whole number at which to stop counting: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

