using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char c = (char) 0x00a9;
        Console.WriteLine("{0,4}", c);
        Console.WriteLine("{0,3}{1,2}", c, c);
        Console.WriteLine("{0,2}{1,4}", c, c);
        Console.WriteLine("{0}{1,2}{2,2}{3,2}", c, c, c, c);
    }
}

