using System;

class ProgramCirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Set perimeter:");
        double r = double.Parse(Console.ReadLine());
        double perimeter = Math.PI * 2 * r;
        double area = Math.PI * r * r;
        Console.WriteLine("Perimeter: {0:f2} \nArea {1:f2}", perimeter, area);
    }
}

