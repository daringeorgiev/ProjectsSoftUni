using System;

class SumОf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Set a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Set b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Set c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Sum: {0}", a+b+c);
    }
}

