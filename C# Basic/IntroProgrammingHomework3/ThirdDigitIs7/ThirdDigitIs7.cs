using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Set a number:");
        int number = int.Parse(Console.ReadLine());
        number = Math.Abs(number);
        if (number < 700)
        {
            Console.WriteLine("False");
        }
        else
        {
            int a = number / 100;
            if (a % 10 == 7)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

