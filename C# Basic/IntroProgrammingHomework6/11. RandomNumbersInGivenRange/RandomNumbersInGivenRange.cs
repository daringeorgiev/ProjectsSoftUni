using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter min:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter max:");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rnd.Next(min, (max+1)));
        }
    }
}

