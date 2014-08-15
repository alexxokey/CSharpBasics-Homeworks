using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Type the width of the rectangle: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Type the height of the rectangle: ");
        double b = double.Parse(Console.ReadLine());
        double perimeter = 2 * (a + b);
        double area = a * b;
        Console.WriteLine("The rectangle's perimeter is: {0}", perimeter);
        Console.WriteLine("The rectangle's area is: {0}", area);
    }
}

