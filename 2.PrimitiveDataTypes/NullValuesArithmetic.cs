using System;
using System.Text;
class NullValuesArithmetic
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("Printing null variables: a = {0}, b = {1}", a, b);
            a += null;
            b += 314;
            Console.WriteLine("Printing the null variables: a: {0} b: {1}", a, b);
        }
    }

