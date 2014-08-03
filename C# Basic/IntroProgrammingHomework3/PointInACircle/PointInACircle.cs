using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Set x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Set y:");
        double y = double.Parse(Console.ReadLine());
        if ((Math.Sqrt(x * x + y * y))<=2)
        {
            //Console.WriteLine("Point is in a Circle");
            Console.WriteLine("True");
        }
        else
        {
            //Console.WriteLine("Point isn't in a Circle");
            Console.WriteLine("False");
        }
    }
}

