using System;

class ComparingFloats
{
    static void Main()
    {
        float f1 = 5.3f;
        float f2 = 6.01f;
        bool greaterf1f2 = (f1 > f2);
        {
            Console.WriteLine("{0} > {1} ({2})", f1, f2, greaterf1f2); //False
        }
        bool greaterf2f1 = (f2 > f1);
        {
            Console.WriteLine("{0} > {1} ({2})", f1, f2, greaterf2f1); //True
        }
    }
}

