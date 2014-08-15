using System;

class PrintLongSequence
{
    static void Main()
    {
        Console.WriteLine("The first 1000 numbers of the sequence are:");
        for (int i = 2; i < 1002 ;i = i + 2 )
        {
            Console.Write(" " + i);
            Console.Write(" " + - (i + 1));
        }
        Console.WriteLine();
    
    }
}

