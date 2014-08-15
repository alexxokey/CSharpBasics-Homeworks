using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = (2 * r) * Math.PI;
        double area = (r * r) * Math.PI;
        Console.WriteLine("The perimeter of the circle is: {0:F2}", perimeter);
        Console.WriteLine("The area of the circle is: {0:F2}", area);

    }
}

