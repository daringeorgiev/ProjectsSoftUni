using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Set n:");
        double sum = 0;
        double number;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Set number {0}",(i+1));
            number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum: {0:f2}", sum);
    }
}

