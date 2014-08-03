using System;
using System.Collections.Generic;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //string[][] matrix = new string[5, ];

        //for (int row = 0; row < (2 * n - 1); row++)
        //{
        //    for (int col = 0; col < (2*n-1); col++)
        //    {
        //        Console.Write(".");
        //    }
        //    Console.WriteLine();
        //}
        

        //first line
        string dots = new string('.', n/2);
        string stars = new string('#', n);
        Console.WriteLine("{0}{1}{2}", dots, stars, dots);

        //Seconf lines
        string dotsSecond = new string('.', n / 2);
        string dotsMiddle = new string('.', n - 2);
        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine("{0}#{1}#{2}", dotsSecond, dotsMiddle, dotsSecond);
        }
        
        //Third line
        string stars3 = new string('#', (n+1)/2);
        Console.WriteLine("{0}{1}{2}", stars3, dotsMiddle, stars3);

        //Last lines
        for (int i = 1; i < n-1; i++)
        {
             string finalDots = new string('.', i);
             string finalDots2 = new string('.', (n*2-3)-2*i);
             Console.WriteLine("{0}#{1}#{0}", finalDots, finalDots2);
        }
        //End line
        string endDots = new string('.', n-1);
        Console.WriteLine("{0}#{0}", endDots);
    }
}

