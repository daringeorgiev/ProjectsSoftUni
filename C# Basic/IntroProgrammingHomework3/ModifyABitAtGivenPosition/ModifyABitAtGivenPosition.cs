using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Set number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Set position:");
        byte position = byte.Parse(Console.ReadLine());
        Console.WriteLine("Set bit value:");
        byte bitValue = byte.Parse(Console.ReadLine());
        //Set mask and result
        int mask;
        int result;
        if (bitValue==0)
        {
            mask = ~(1 << position);
            result = number & mask;
            Console.WriteLine(result);
        }
        else if (bitValue == 1)
        {
            mask = (1<<position);
            result = number | mask;
            Console.WriteLine(result);
        }
        else 
        {
            Console.WriteLine("Error with bit value");
        }
    }
}

