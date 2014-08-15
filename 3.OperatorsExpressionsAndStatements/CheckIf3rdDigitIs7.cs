using System;

class CheckIf3rdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int restNumber = number / 100;
        int thirdDigit = restNumber % 10;
        if (thirdDigit == 7)
        {
            Console.WriteLine("The third digit is 7!");
        }
        else
        {
            Console.WriteLine("The third digit isn't 7!");
        }
    }
}

