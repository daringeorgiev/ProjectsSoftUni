using System;
using System.Collections.Generic;
class PrimesInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Set Start number:");
        int startNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Set End number:");
        int endNum = int.Parse(Console.ReadLine());

        List<int> result= (FindPrimesInRange(startNum, endNum));
        foreach (var num in result)
        {
            if (result[0]!=num)
            {
                Console.Write(", ");
            }
            Console.Write(num);
        }
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> numbers = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                numbers.Add(i);
            }
        }
        return numbers;
    }
    
    private static bool IsPrime(long n)
    {
        bool check = true;
        if (n < 2)
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

