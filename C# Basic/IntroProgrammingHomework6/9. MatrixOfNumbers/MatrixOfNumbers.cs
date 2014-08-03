using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < (n+i); j++)
            {
                Console.Write("{0,3}",j);
                if (j==n+i-1)
                {
                    Console.WriteLine();    
                }
            }
            
        }
    }
}

