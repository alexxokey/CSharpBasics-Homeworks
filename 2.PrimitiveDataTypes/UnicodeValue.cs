using System;

class UnicodeValue
{
    static void Main()
    {
        byte a = 0x48;
        Console.WriteLine("The code of '{0}' is: {1}", a, (char)a);
    }
}

