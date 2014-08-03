using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Set width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Set height:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter is: {0:F3}", (2*width+2*height));
        Console.WriteLine("Area is: {0:F3}", (width*height));
    }
}

