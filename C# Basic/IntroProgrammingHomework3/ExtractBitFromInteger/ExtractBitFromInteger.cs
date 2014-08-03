using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Set number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Set index:");
        byte index = byte.Parse(Console.ReadLine());
        int rightNumber = number >> index;
        Console.WriteLine(rightNumber & 1);
    }
}

