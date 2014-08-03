using System;

class CountOfLetters
{
    static void Main()
    {
        //Read from console
        string[]  leter= Console.ReadLine().Split(' ');
        
        //Sort
        Array.Sort(leter);
        int repeats = 1;
        //Loop
        for (int i = 1; i < leter.Length; i++)
        {
            //int repeats = 1;
            //Check
            if (leter[i]==leter[i-1])
            {
                repeats++;
            }
            else
            {
                //Print
                Console.WriteLine("{0} -> {1}", leter[i - 1], repeats);
                repeats = 1;
            }
            if (i==leter.Length-1)
            {
                //Print
                Console.WriteLine("{0} -> {1}", leter[i], repeats);
            }
        }
    }
}

