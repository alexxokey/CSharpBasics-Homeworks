using System;
class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Enter the first real number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter the second real number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Enter the third real number: ");
        double thirdNum = double.Parse(Console.ReadLine());
        if (firstNum >= secondNum)
        {
            if (secondNum >= thirdNum)
            {
                Console.WriteLine("The numbers in descending order: {0} {1} {2}", firstNum, secondNum, thirdNum);
            }
            else
            {
                Console.WriteLine("The numbers in descending order: {0} {1} {2}", firstNum, thirdNum, secondNum);
            }
        }
        else
        {
            if (secondNum >= thirdNum)
            {
                if (firstNum >= thirdNum)
                {
                    Console.WriteLine("The numbers in descending order: {0} {1} {2}", secondNum, firstNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("The numbers in descending order: {0} {1} {2}", secondNum, thirdNum, firstNum );
                }
            }
            else
            {
                if (secondNum >= firstNum)
                {
                    Console.WriteLine("The numbers in descending order: {0} {1} {2}", thirdNum, secondNum, firstNum);
                }
                else
                {
                    Console.WriteLine("The numbers in descending order: {0} {1} {2}", thirdNum, firstNum, secondNum);
                }
            }
        }
    }
}

