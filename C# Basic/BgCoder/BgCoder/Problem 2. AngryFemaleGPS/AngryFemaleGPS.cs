using System;

class AngryFemaleGPS
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        n = Math.Abs(n);

        long even = 0;
        long odd = 0;
        long temp;

        do
        {
            temp = n % 10;
            if (temp % 2 == 0)
            {
                even += temp;
            }
            else
            {
                odd += temp;
            }
            n = n / 10;
            
        } while (n>0);


        //char[] num = n.ToCharArray();
      
        //long even = 0;
        //long odd = 0;
        //long temp;

        ////Loop to chek sum of even and odd numbers
        //for (int i = 0; i < num.Length; i++)
        //{
        //    temp = (int)char.GetNumericValue(num[i]);
        //    if (temp % 2 == 0)
        //    {
        //        even += temp;
        //    }
        //    else
        //    {
        //        odd += temp;
        //    }
        //}
        //Check sums
        if (even == odd)
        {
            Console.WriteLine("straight {0}", even);
        }
        else if (even > odd)
        {
            Console.WriteLine("right {0}", even);
        }
        else
        {
            Console.WriteLine("left {0}", odd);
        }
      
    }
}

