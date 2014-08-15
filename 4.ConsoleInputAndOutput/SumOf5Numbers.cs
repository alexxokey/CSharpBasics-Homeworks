using System;
class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter the 5 numbers(remain space between each two and press after all of them): ");
        string[] userInput = Console.ReadLine().Split();
        double a = Convert.ToInt32(userInput[0]);
        double b = Convert.ToInt32(userInput[1]);
        double c = Convert.ToInt32(userInput[2]);
        double d = Convert.ToInt32(userInput[3]);
        double e = Convert.ToInt32(userInput[4]);
        Console.WriteLine("The sum of the numbers is: {0}", a + b + c + d + e);
    }
}

