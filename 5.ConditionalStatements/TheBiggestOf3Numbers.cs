using System;
class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The number {0} is the biggest!", a);
            }
            else
            {
                Console.WriteLine("The number {0} is the biggest!", c);
            }
        }
        else  
        {
            if (b > c)
            {
            Console.WriteLine("The number {0} is the biggest!", b);
            }
            else
            {
                Console.WriteLine("The number {0} is the biggest!", c);
            }
        }
    }
}

