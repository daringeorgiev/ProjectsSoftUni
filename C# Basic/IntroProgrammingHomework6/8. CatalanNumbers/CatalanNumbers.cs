using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        ulong result1 = 1;
        ulong result2 = 1;

        for (int i = (n+2); i <= 2*n; i++)
        {
            result1 *= Convert.ToUInt64(i);
        }
        for (int i = 1; i <= n; i++)
        {
            result2 *= Convert.ToUInt64(i);
        }
        Console.WriteLine("Result: {0}", result1 / result2);     
    }
}

