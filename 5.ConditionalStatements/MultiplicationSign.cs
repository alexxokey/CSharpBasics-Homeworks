using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        if (a < 0)
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    Console.WriteLine("The product of the three numbers is negative!");
                }
                else
                {
                    Console.WriteLine("The product of the three numbers is positive!");
                }
            }
            else
            {
                if (c < 0)
                {
                    Console.WriteLine("The product of the three numbers is negative!");
                }
                else
                {
                    Console.WriteLine("The product of the three numbers is positive!");
                }
            }
        }
        else if (a > 0)
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    Console.WriteLine("The product of the three numbers is positive!");
                }
                else
                {
                    Console.WriteLine("The product of the three numbers is negative!");
                }
            }
            else
            {
                if (c < 0)
                {
                    Console.WriteLine("The product of the three numbers is negative!");
                }
                else
                {
                    Console.WriteLine("The product of the three numbers is positive!");
                }
            }
        }
        else if ((a == 0) || (b == 0) || (c == 0))
        {
            Console.WriteLine("The product of the three numbers is 0!");
        }
    }    
}


