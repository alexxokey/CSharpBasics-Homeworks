using System;
class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter a number between 0 and 500: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a floating-point number: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Enter another floating point number: ");
        decimal c = decimal.Parse(Console.ReadLine());
        Console.WriteLine("{0,-10:x}| " + "{1}|" + "{2,10:F2}|{3,-10:F3}|", a,(Convert.ToString(a, 2).PadLeft(10,'0')), b, c);
    }
}

