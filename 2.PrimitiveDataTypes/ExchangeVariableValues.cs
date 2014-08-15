using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = {0} and b = {1}", a, b);
        int a1 = b ;
        b = a;
        Console.WriteLine("a = {0} and b = {1}", a, b);
    }
}

