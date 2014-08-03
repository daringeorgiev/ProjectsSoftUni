using System;

class CalculateNKSecondTime
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter k:");
        int k = int.Parse(Console.ReadLine());
        ulong result1 = 1;
        ulong result2 = 1;

        for (int i = ((n-k)+1); i <= n; i++)
        {
            result1 *= Convert.ToUInt64(i);  
        }
        for (int i = 1; i <= k; i++)
        {
            result2 *= Convert.ToUInt64(i);
        }
        Console.WriteLine("Result: {0}", result1 / result2);     
    }
}

