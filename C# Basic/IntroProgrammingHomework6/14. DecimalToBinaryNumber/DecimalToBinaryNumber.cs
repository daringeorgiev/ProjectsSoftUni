using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        //Set n
        Console.WriteLine("Please enter n:");
        long n = long.Parse(Console.ReadLine());
        //Var
        bool result=true;
        string binar="";
        //Loop to divide n by 2
        while (result)
        {
            if(n%2==0)
            {
                binar=binar + "0";
            }
            else
            {
                binar = binar + "1";
            } 
            n=n/2;
            if (n == 0)
            {
                result = false;
            }
        }
        //Reverse string
        char[] binarReversed = binar.ToCharArray();
        for (int i = binarReversed.Length; i >0; --i)
        {
            Console.Write(binarReversed[i-1]);
            //Last Writeline
            if (i==1)
            {
                Console.WriteLine();
            }
        }
    }
}
