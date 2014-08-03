using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Set a number:");
        int number=int.Parse(Console.ReadLine());
        bool divided;
        divided = ((number%5==0)&&(number%7==0));
        Console.WriteLine("Result: {0}", divided);
    }
}

