using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Which number of the Catalan numbers would you like to know: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 1 && n < 100)
        {
            BigInteger factorielN = 1;
            BigInteger factoriel2N = 1;
            BigInteger factNplus = 1;
            BigInteger result = 1;
            for (int i = 1; i <= (2 * n); i++)
            {
                factoriel2N *= i;
            }
            for (int j = 1; j <= (n + 1); j++)
            {
                factNplus *= j;
            }
            for (int k = 1; k <= n; k++)
            {
                factorielN *= k;
            }
            result = factoriel2N / (factNplus * factorielN);
            Console.WriteLine("The number is: {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid Input:The number should be between 1 and 100!");
        }
    }
}

