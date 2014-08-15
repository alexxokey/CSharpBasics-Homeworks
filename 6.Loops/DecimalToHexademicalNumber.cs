using System;
using System.Globalization;
class DecimalToHexademicalNumber
{
    static void Main()
    {
        Console.Write("Enter you decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string hexaStr = decimalNumber.ToString("X");

        long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

        Console.WriteLine(hexaStr);
    }
}

