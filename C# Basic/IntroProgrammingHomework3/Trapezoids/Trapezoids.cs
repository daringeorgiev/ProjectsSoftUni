using System;

class Trapezoids
{
    static void Main()
    {
        //Set parameters
        Console.WriteLine("Set a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Set b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Set h:");
        double h = double.Parse(Console.ReadLine());
        //Calculate
        Console.WriteLine("Area is: {0:F3}", (((a+b)/2d))*h);
    }
}

