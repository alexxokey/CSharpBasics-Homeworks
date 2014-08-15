using System;

class Four_DigitNumber
{
    static void Main()
    {
        Console.WriteLine("Write a 4-Digit number and press enter after every digit of the number: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("The Sum of the digits is:{0}", (a + b + c + d));
        Console.WriteLine("The number in reversed order: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in the first position: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Exchange of the second and the third digits: {0}{1}{2}{3}", a,c,b,d);
    }
}

