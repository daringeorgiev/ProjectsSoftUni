using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Set Four-Digit number:");
        int number = int.Parse(Console.ReadLine());
        //Set digits
        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10;
        int a = number / 1000;
        //Print
        Console.WriteLine("Sum of the digits: {0}", (a + b + c + d));
        Console.WriteLine("Reversed order: {3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("Last digit in the first position: {3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("Exchanges the second and the third digits: {0}{2}{1}{3}", a, b, c, d);
    }
}

