using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter \"a\" of the quadric equation: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter \"b\" of the quadric equation: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter \"c\" of the quadric equation: ");
        double c = double.Parse(Console.ReadLine());
        double discriminant = (b * b) - (4 * a * c);
        if (discriminant == 0)
        {
            Console.WriteLine("The two roots are equal! x = {0}", (-b + Math.Sqrt(discriminant)) / 2 * a);
        }
        else if (discriminant > 0)
        {
            Console.WriteLine("The two roots are: x = {0} and x2 = {1}!", (-b + Math.Sqrt(discriminant)) / 2 * a, (-b - Math.Sqrt(discriminant)) / 2 * a);
        }
        else
        {
            Console.WriteLine("There are no real roots!");
        }
    }
}

