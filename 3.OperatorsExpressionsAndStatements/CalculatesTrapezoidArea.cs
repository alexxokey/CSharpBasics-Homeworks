using System;
class CalculatesTrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter the first side of the trapezoid: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Enter the second side of the trapezoid: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the trapezoid: ");
        double height = double.Parse(Console.ReadLine());
        double area = (firstSide + secondSide) / 2 * height;
        Console.WriteLine("The area of the trapezoid is: {0}", area);
    }
}

