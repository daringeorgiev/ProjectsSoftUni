using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Set a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Set b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Set c:");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        if (discriminant==0)
        {
            Console.WriteLine("There are only one real root: {0}", (-b/2*a));
        }
        else if (discriminant>0)
        {
            Console.WriteLine("Root1: {0}\nRoot2: {1}", ((-b - Math.Sqrt(discriminant)) / (2 * a)), ((-b + Math.Sqrt(discriminant)) / (2 * a)));
        }
        else
        {
            Console.WriteLine("There aren't real roots");
        }

    }
}

