﻿using System;

class GravityOfTheMoon
{
    static void Main()
    {
        Console.Write("Your weight is: ");
        double weight = double.Parse(Console.ReadLine());
        double weightOnTheMoon = (weight * 0.17);
        Console.WriteLine("Your weight on the Moon is: {0}", weightOnTheMoon );
        
    }
}

