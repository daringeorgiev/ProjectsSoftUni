using System;

class BitwiseExtractBitNumber3
{
    static void Main()
    {
        Console.WriteLine("Set number:");
        int number = int.Parse(Console.ReadLine());
        int rightNumber = number >> 3;
        Console.WriteLine(rightNumber & 1);
    }
}

