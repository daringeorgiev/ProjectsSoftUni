using System;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        ulong n = ulong.Parse(Console.ReadLine());
        //Calculate N!
        ulong fact=1;
        int zeroes = 0;
        for (ulong i = 2; i < n+1; i++)
        {
            fact *= i;
            //Check last digit
            while (fact%10==0)
            {
                zeroes += 1;
                fact = fact / 10;
            }
        }
        //Print
        Console.WriteLine("Trailing zeroes of {1}!: {0}", zeroes, n);
        
        //Second method, but only for small numbers

        ////Convert to string
        //string result = Convert.ToString(fact);
        //char[] digit = result.ToCharArray();
        ////Loop to calculate last digits
        //int lastDigits = 0;
        //for (int i = (digit.Length-1); i > -1; i--)
        //{
        //    if (digit[i]=='0')
        //    {
        //        lastDigits+=1;
        //    }
        //    else
        //    {
        //        break;
        //    }
        //}
        //Console.WriteLine("Trailing zeroes of {1}!: {0}", lastDigits, n);
        //Console.WriteLine("Explaination: {0}", result);
    }
}

