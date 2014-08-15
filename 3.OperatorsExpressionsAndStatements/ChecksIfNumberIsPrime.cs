using System;
class ChecksIfNumberIsPrime
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 0 and 100: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 0 || n == 1)
        {
            Console.WriteLine(n + " is not prime number");
            Console.ReadLine();
        }
        else
        {
            for (int a = 2; a <= n / 2; a++)
            {
                if (n % a == 0)
                {
                    Console.WriteLine(n + " is not prime number");
                    return;
                }

            }
            Console.WriteLine(n + " is a prime number");

        }
    }
}
