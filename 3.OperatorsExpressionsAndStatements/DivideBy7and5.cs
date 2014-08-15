using System;

class DivideBy7and5
{
    static void Main()
    {
        Console.Write("Write a whole number: ");
        int a = int.Parse(Console.ReadLine());
        bool isDevided = (a % 5 == 0) && (a % 7 == 0);
        Console.WriteLine("The Number can be divided by 5 and by 7 without a reminder. -> {0}", isDevided);

    }
}

