using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Write an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write wich position of the integer you want to know: ");
        int p = int.Parse(Console.ReadLine());
        int fakeBit = 1 << p;
        int realBit = n & fakeBit;
        if (realBit == 0)
        {
            Console.WriteLine("On the {0} position of the integer there is 0", p);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        }
        else
        {
            Console.WriteLine("On the {0} position of the integer there is 1", p);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        }
    }
}

