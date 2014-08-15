using System;

class BitwiseExtractBit
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int posInteger = int.Parse(Console.ReadLine());
        int fakeBit = 1 << 3;
        int foundBit = posInteger & fakeBit;
        if (foundBit == 0)
        {
        Console.WriteLine("The 3rd digit is 0");
        }
        else
        {
            Console.WriteLine("The third digit is 1");
        }
    }
}

