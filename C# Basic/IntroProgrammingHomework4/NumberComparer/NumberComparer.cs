using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Set a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Set b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Greater: {0}", a>b ? a:b);
    }
}

