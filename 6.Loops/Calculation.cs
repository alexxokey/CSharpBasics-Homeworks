using System;
using System.Numerics;
   
class CalculateN_K__N_K_
{
    static void Main()
    {
        Console.Write("Enter n (must be between 1 and 100): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k (must be between 1 and 100 and smaller than n): ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger result;
        if (n > k)
        {
            while (n > 1)
            {
                factorialN *= n;
                n--;
            }
            while (k>1)
            {
                factorialK *= k;
                k--;
            }
            result = n / k;

        }
    }
}

