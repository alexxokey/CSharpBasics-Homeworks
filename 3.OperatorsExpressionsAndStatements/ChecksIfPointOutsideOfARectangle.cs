using System;
class ChecksIfPointOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("Enter the X coordinate of the point: ");
        double xPoint = double.Parse(Console.ReadLine());
        Console.Write("Enter the Y coordinate of the point: ");
        double yPoint = double.Parse(Console.ReadLine());
        if ((xPoint >= -0.5) & (xPoint <= 2.5) & (yPoint >= -0.5) & (yPoint <= 2.5) )
        {
            Console.WriteLine("Your point is within the circle!");
            if ((xPoint >= -1) & (xPoint <= 6) & (yPoint >= -1) & (yPoint <= 1))
            {
                Console.WriteLine("Your point is within the circle and the rectangle!");
            }
            else
            {
                Console.WriteLine("But it's not within the rectangle as well!");
            }
        }
        else
        {
            Console.WriteLine("Your point is not in the circle!");
        }
    }
}

