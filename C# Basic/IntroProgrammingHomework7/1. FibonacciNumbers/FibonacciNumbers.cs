using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Set n:");
        int n = int.Parse(Console.ReadLine());
        //int fib = 0;
        int[] fib = new int[n+2];
        fib[0] = 0;
        fib[1] = 1;
        fib[2] = 1;
        if (n>2)
        {
            for (int i = 3; i <= n+1; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
        }
     
        Console.WriteLine(fib[n+1]);
    }
}

