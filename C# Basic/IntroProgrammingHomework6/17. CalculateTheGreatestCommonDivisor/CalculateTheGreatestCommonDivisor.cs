using System;

class CalculateTheGreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Please enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter b:");
        int b = int.Parse(Console.ReadLine());
        if (b==0)
        {
            Console.WriteLine("The Greatest Common Divisor is: {0}", a);
        }
        else if (a==0)
        {
            Console.WriteLine("The Greatest Common Divisor is: {0}", b);
        }
        else 
        {
            //Euclidean algorithm
            int mod = a % b;
            while (mod !=0)
            {
                int temp = mod;
                mod = b % mod;
                b = temp;
            }
            Console.WriteLine("The Greatest Common Divisor is: {0}", b);
        }
    }
}

