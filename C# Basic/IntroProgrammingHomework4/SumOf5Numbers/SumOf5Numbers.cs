using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Set 5 numbers in a single line, separated by a space:");
        string numbers = Console.ReadLine();
        string[] digit = numbers.Split(' ');
        double sum = 0;

        for (int i = 0; i < digit.Length; i++)
        {
            sum += double.Parse(digit[i]);
        }
        Console.WriteLine("Sum is: {0}",sum);
    }
}

