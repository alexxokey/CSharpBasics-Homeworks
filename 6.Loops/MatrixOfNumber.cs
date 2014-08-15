using System;

class MatrixOfNumber
{
    static void Main()
    {
        Console.Write("Enter a positive number(between 1 and 20): ");
        int n = int.Parse(Console.ReadLine());

        if (n > 1 && n < 20)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n + i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
