using System;

class SequenceTo1000
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0,5}", i);
            }
            else
            {
                Console.WriteLine("{0,5}", -i);
            }
        }
    }
}

