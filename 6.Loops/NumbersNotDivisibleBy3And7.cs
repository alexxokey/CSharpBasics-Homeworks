using System;
class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        uint positiveInt = uint.Parse(Console.ReadLine());
        uint n = 1;
        while (n <= positiveInt)
        {
            if ((n % 3 != 0) & (n % 7 != 0))
            {
                Console.WriteLine(n);
            }
                n++;
        }
    }
}

