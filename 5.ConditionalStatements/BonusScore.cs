using System;
class BonusScore
{
    static void Main()
    {
        Console.Write("Enter your score(Must be between 1 and 9!): ");
        int a = int.Parse(Console.ReadLine());
        if (a <= 10 & a >= 1)
        {
            if (a >= 1 & a <= 3)
            {
                Console.WriteLine("Your score is: {0}", a * 10);
            }
            if (a >= 4 & a <= 6)
            {
                Console.WriteLine("Your score is: {0}", a * 100);
            }
            if (a >= 7 & a <= 9)
            {
                Console.WriteLine("Your score is: {0}", a * 1000);
            }
        }
        else
        {
            Console.WriteLine("Invalid score!");
        }
    }
}

