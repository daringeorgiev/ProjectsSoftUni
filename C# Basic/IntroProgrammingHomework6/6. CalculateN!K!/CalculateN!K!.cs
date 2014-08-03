using System;

class CalculateNK
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter k:");
        int k = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = 1; i <= n; i++)
		{
            if (i>k)
            {
                result *= i;
            }
		}
        Console.WriteLine("N!/K!={0}", result);
    }
}

