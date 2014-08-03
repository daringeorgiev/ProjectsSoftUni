using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = 5;
        Console.WriteLine(a);
        b = 5.55;
        Console.WriteLine(b);
    }
}

