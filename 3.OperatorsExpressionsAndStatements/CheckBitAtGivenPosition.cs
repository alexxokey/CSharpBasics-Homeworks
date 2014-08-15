using System;
class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Write an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write wich position of the integer you want to know: ");
        int p = int.Parse(Console.ReadLine());
        int fakeBit = n >> p;
        int realBit = fakeBit & 1;
        bool ifNis1 = realBit == 1;
        Console.WriteLine("The number of position {0} is 1: {1}",p, ifNis1);
        Console.WriteLine(Convert.ToString(n,2).PadLeft(16, '0'));
    }
}

