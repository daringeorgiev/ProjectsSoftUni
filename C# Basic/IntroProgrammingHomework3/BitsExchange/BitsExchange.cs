using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Set number:");
        long number = long.Parse(Console.ReadLine());

        //Get bits
        long bit3 = ((number >> 3)&1);
        long bit4 = ((number >> 4) & 1);
        long bit5 = ((number >> 5) & 1);
        long bit24 = ((number >> 24) & 1);
        long bit25 = ((number >> 25) & 1);
        long bit26 = ((number >> 26) & 1);

        //Bits exchange
        long mask;
        //bit3
        if (bit3 == 0)
        {
            mask = ~(1 << 24);
            number = number & mask;
            mask = 0;
        }
        else if (bit3 == 1)
        {
            mask = (1 << 24);
            number = number | mask;
            mask = 0;
        }
 
        //bit4
        if (bit4 == 0)
        {
            mask = ~(1 << 25);
            number = number & mask;
            mask = 0;
        }
        else if (bit4 == 1)
        {
            mask = (1 << 25);
            number = number | mask;
            mask = 0;
        }
       
        //bit5
        if (bit5 == 0)
        {
            mask = ~(1 << 26);
            number = number & mask;
            mask = 0;
        }
        else if (bit5 == 1)
        {
            mask = (1 << 26);
            number = number | mask;
            mask = 0;
        }

        //bit24
        if (bit24 == 0)
        {
            mask = ~(1 << 3);
            number = number & mask;
            mask = 0;
        }
        else if (bit24 == 1)
        {
            mask = (1 << 3);
            number = number | mask;
            mask = 0;
        }

        //bit25
        if (bit25 == 0)
        {
            mask = ~(1 << 4);
            number = number & mask;
            mask = 0;
        }
        else if (bit25 == 1)
        {
            mask = (1 << 4);
            number = number | mask;
            mask = 0;
        }

        //bit26
        if (bit26 == 0)
        {
            mask = ~(1 << 5);
            number = number & mask;
            mask = 0;
        }
        else if (bit26 == 1)
        {
            mask = (1 << 5);
            number = number | mask;
            mask = 0;
        }

        //Result
        Console.WriteLine(number);
    }
}

