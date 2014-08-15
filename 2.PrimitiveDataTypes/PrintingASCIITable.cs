using System;

class PrintingASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 255; i++)
        {
            Console.WriteLine("Character {0} = {1}", i, (char)i);
        }
    }
}

