using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Set a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Set b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Set c:");
        double c = double.Parse(Console.ReadLine());
       
        if (a>0 && b>0 && c>0)
        {
            Console.WriteLine("+");
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("-");
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("-");
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("+");
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("-");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("+");
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}

