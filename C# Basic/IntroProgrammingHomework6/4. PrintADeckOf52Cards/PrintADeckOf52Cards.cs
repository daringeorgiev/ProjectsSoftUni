using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        string[] color = { "♠", "♥", "♦", "♣" };
        string[] mark = {"J", "Q", "K", "A"};
        byte i = 0;

        for (int j = 2; j <=10; j++)
        {
            Console.WriteLine("{0,2}{1} {0,2}{2} {0,2}{3} {0,2}{4}", j, color[i], color[i + 1], color[i + 2], color[i+3]);
            if (j==10)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.WriteLine("{0,2}{1} {0,2}{2} {0,2}{3} {0,2}{4}", mark[k], color[i], color[i + 1], color[i + 2], color[i + 3]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}

