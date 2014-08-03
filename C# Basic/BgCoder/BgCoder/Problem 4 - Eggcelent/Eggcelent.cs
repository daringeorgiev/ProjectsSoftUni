using System;

class Eggcelent
{
    static void Main()
    {
        ////int n = int.Parse(Console.ReadLine());
        //int n = 1;
        //int eggHeight = 2 * n;
        //int eggWidth = 3 * n - 1;
        //int width = 3 * n + 1;
        //int eggSize = n - 1;

        //Console.Write("n = ");
        //string consoleInput = Console.ReadLine();
        //int n = int.Parse(consoleInput);
        //Console.WriteLine();

        //for (int row = 1; row <= n; row++)
        //{
        //    for (int column = 1; column <= row; column++)
        //    {
        //        Console.Write("{0} ", column);
        //    }
        //    Console.WriteLine();
        //}

        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int spaceCount = (n - i);
            string space = new string(' ', spaceCount);
            Console.Write(space);
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }


    }
}

