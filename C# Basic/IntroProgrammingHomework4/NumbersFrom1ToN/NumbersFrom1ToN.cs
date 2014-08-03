using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Set n:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i+1);
        }
    }
}

