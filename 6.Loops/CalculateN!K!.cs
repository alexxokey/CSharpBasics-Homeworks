using System;
using System.Numerics;
class CalculateN_K
{
    static void Main()
    {
        Console.Write("Enter n (must be between 1 and 100): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k (must be between 1 and 100 and smaller than n): ");
        int k = int.Parse(Console.ReadLine());

        if (n > k && n > 1 && k > 1 && n < 100 && k < 100)
        {
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger result = 0;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            do
            {
                factorialK *= k;
                k--;
            } while (k >= 1);
            result = factorialN / factorialK;
            Console.WriteLine("The dividing of N! and K! = {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid Input: \"K\" should be smaller than \"N\" and both of them should be between 100!");
        }

    }
}

