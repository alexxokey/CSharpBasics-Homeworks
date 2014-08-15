using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Check bit of position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Value of bit [0 or 1]: ");
        int v = int.Parse(Console.ReadLine());
        if (v == 1)
        {
            int set1 = 1 << p;
            int foundBit = n | set1;
            Console.WriteLine(Convert.ToString(foundBit, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBit);
        }
        else
        {
            int set0 = ~(0 << p);
            int foundBit0 = n & set0;
            Console.WriteLine(Convert.ToString(foundBit0, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBit0);
        }
    }
}

