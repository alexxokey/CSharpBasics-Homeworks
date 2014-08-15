using System;
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.Write("1 --> int \n2 --> double \n3 --> string \nPlease choose a type: ");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                Console.Write("Please enter an integer: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
            }
            if (type == 2)
            {
                Console.Write("Please enter a double: ");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
            }
            if (type == 3)
            {
                Console.Write("Please enter a string: ");
                string word = Console.ReadLine();
                Console.WriteLine("{0}*", word);
            }
        }
    }

