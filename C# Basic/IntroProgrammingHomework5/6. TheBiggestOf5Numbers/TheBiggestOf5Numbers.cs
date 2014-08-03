using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Set a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Set b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Set c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Set d:");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Set e:");
        double e = double.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b >= c && b>=d && b>=e)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b && c >= d && c >= e)
        {
            Console.WriteLine(c);
        }
        else if (d > a && d > b && d > c && d >= e)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(e);
        }
    }
}

