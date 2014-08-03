using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.WriteLine("Set x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Set y:");
        double y = double.Parse(Console.ReadLine());
        x--;
        y--;
        if (((Math.Sqrt(x * x + y * y)) <= 1.5) && (y > 0))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

