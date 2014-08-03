using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Set a number:");
        int number = int.Parse(Console.ReadLine());
        if (number%2.0 == 0)
        {
            Console.WriteLine("Number {0} is even",number);
        }
        else 
        {
            Console.WriteLine("Number {0} is odd", number);
        }

    }
}

