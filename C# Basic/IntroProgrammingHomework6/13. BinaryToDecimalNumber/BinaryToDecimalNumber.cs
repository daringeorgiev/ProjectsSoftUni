using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter binary number:");
        string number = Console.ReadLine();
        char[] num = number.ToCharArray();
        //Check if number is 0
        if (num[0] == '0' && num.Length == 1)
        {
            Console.WriteLine("Decimal is: 0");
        }
        else
        {
            //Var
            long sum ;
            long two = 1;
            //Check last bit 0 or 1 (It is necessary for 2 extends)
            //It can be released with Math.Row(), wihtout this check, but the program would be slower.
            if (num[(num.Length-1)]=='1')
            {
                sum = 1;
            }
            else
            {
                sum = 0;
            }
            //Loop
            for (int i = (num.Length - 2); i > -1; i--)
            {
                two *= 2;
                if (num[i] == '1')
                {
                    sum += two;
                }
            }
            //Print
            Console.WriteLine("Decimal is: {0}", sum);
        }
    }
}

