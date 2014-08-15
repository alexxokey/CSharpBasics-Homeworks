using System;
class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        double e = double.Parse(Console.ReadLine());
        if (a >= b)
        {
            if (a >= c)
            {
                if (a >= d)
                {
                    if (a >= e)
                    {
                        Console.WriteLine("The biggest number is: {0}", a);
                    }
                    else
                    {
                        Console.WriteLine("The biggest number is: {0}", d);
                    }
                }
                else
                {
                    if (d >= e)
                    {
                        Console.WriteLine("The biggest number is: {0}", d);
                    }
                    else
                    {
                        Console.WriteLine("The biggest number is: {0}", e);
                    }
                }
            }
            else
            {
                if (c >= d & c >= e)
                {
                    Console.WriteLine("The biggest number is: {0}", c);
                }
                else if (d >= e)
                {
                    Console.WriteLine("The biggest number is: {0}", d); 
                }
                else if (e >= d)
                {
                    Console.WriteLine("The biggest number is: {0}", e);
                }
            }
        }
        else
        {
            if (b >= c & b >= d & b >= e)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else if (c >= d & c >= e)
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
            else if (d >= e & d >= c)
            {
                Console.WriteLine("The biggest number is: {0}", d); 
            }
            else if (e >= d & e >= c)
            {
                Console.WriteLine("The biggest number is: {0}", e);
            }    
        }
    }
}

