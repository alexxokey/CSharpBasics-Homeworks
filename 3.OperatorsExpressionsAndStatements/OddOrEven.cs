using System;

class OddOrEven
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("The number: " + a + " is even!");
        }
        else
        {
            Console.WriteLine("The number: " + a + " is odd");
        }
    }
}

