using System;
class Calculate
{
    static void Main()
    {

        Console.Write("Please, enter a whole positive number for N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a whole integer number for X = ");
        int x = int.Parse(Console.ReadLine());

        double factN = 1.0;
        double multiX = 1.0;
        double sum = 1.0;

        for (int i = 1; i < n; i++)
        {
            factN *= i;
            multiX *= x; 
            sum += (factN / multiX);
        }
        Console.WriteLine("The Sum is: {0:F5}", sum);
    }
}

