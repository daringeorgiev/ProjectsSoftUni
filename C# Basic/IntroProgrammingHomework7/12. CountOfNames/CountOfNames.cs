using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        //Read from console
        string[] names = Console.ReadLine().Split(' ');

        //Sort
        Array.Sort(names);

        //Loop
        int repeats = 1;
        for (int i = 1; i < names.Length; i++)
        {
            //Check
            if (names[i] == names[i - 1])
            {
                repeats++;
            }
            else
            {
                //Print
                Console.WriteLine("{0} -> {1}", names[i - 1], repeats);
                repeats = 1;
            }
            if (i == names.Length - 1)
            {
                //Print
                Console.WriteLine("{0} -> {1}", names[i], repeats);
            }
        }
    }
}

