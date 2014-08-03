using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Set a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Set b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Set c:");
        double c = double.Parse(Console.ReadLine());
        
        if (a>=b && a>=c)
        {
            Console.WriteLine(a);
        }
        else if (b>a && b>=c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

