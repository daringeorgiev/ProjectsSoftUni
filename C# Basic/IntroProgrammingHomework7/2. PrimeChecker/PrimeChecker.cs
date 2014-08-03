using System;
using System.Numerics;


class PrimeChecker
{
    static void Main()
    {
        Console.WriteLine("Set n:");
        long  n=long.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n));
    }

    private static bool IsPrime(long n)
    {
        bool check = true;
        if (n<2)
        {
            check = false;
        }
        else
        {
            int divider = 2;
            double maxDivider = Math.Sqrt(n);

            while (divider <= maxDivider)
            {
                if (n % divider == 0)
                {
                    return false;
                }

                divider++;
            }
        }
        return check;
    }
}

