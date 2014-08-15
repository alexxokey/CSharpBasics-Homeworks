using System;
class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers will be summed: ");
        double a = double.Parse(Console.ReadLine());
        double sum = 0.00;
        double number = 0.00;
        for (int i = 0; i < a; i++)
        {
            Console.Write("Enter number: ");
            number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is: {0}", sum);

    }
}

