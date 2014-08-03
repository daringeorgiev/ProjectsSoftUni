using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Start number:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Final number:");
        int final = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = start; i <= final; i++)
        {
            if (i%5==0)
            {
                count++;
            }
        }
        Console.WriteLine("Count is: {0}", count);
    }
}

