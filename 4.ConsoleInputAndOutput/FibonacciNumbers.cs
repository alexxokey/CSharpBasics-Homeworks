using System;
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want from the Fibonacci numbers: ");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write(a + " " + b + " ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }
        }
    }
}

