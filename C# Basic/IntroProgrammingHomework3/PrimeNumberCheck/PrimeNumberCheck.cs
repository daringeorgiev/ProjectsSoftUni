using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Set a number: ");
        sbyte number = sbyte.Parse(Console.ReadLine());
        byte counter=0;
        if (number <= 1)
        {
            Console.WriteLine("False");
        }
        else 
        {
            for (int i = 2; i < 100; i++)
            {
                if (number%i==0)
                {
                    counter++;
                }
            }
            if (counter > 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}

