using System;

class SequenceTo10
{
    static void Main()
    {
        for (int i = 2; i <=11; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0,3}", i);
            }
            else
            {
                Console.WriteLine("{0,3}", -i);
            }
        }
    }
}

