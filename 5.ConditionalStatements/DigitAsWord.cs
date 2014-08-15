using System;
class DigitAsWord
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int digit = int.Parse(Console.ReadLine());
        switch (digit)
        {
            case '1': Console.WriteLine("The word representation of the digit is: \"One\"!");
                break;
            case '2': Console.WriteLine("The word representation of the digit is: \"Two\"!");
                break;
            case '3': Console.WriteLine("The word representation of the digit is: \"Three\"!");
                break;
            case '4': Console.WriteLine("The word representation of the digit is: \"Four\"!");
                break;
            case '5': Console.WriteLine("The word representation of the digit is: \"Five\"!");
                break;
            case '6': Console.WriteLine("The word representation of the digit is: \"Sixs\"!");
                break;
            case '7': Console.WriteLine("The word representation of the digit is: \"Seven\"!");
                break;
            case '8': Console.WriteLine("The word representation of the digit is: \"Eight\"!");
                break;
            case '9': Console.WriteLine("The word representation of the digit is: \"Nine\"!");
                break;
            default: Console.WriteLine("Not a digit!");
                break;
        }
    }
}

