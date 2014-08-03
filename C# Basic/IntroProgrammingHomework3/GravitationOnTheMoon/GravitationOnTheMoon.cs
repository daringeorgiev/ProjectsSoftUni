using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Set Earth weight:");
        float weight = float.Parse(Console.ReadLine());
        weight *= (17f / 100);
        Console.WriteLine("Moon weight is: {0:F3}", weight);
    }
}

