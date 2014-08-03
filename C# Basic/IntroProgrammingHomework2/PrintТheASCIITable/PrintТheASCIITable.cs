using System;

class PrintТheASCIITable
{
    static void Main()
    {
        char c;
        for (int i = 0; i < 255; i++)
        {
            c = (char)i;
            Console.WriteLine(c);
        }
    }
}

