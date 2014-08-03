using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Set number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Set index:");
        byte index = byte.Parse(Console.ReadLine());
        int rightNumber = number >> index;
        bool bit=((rightNumber & 1)==1);
        Console.WriteLine(bit);
    }
}

