﻿using System;
class CheckForPlayCard
{
    static void Main()
    {
        Console.Write("Enter the string: ");
        string a = Console.ReadLine();
        switch (a)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":  
            case "10":  
            case "J":  
            case "Q":
            case "K":
            case "A": Console.WriteLine("Yes!");
                break;
            default: Console.WriteLine("No!");
                break;  
        }

    }
}

