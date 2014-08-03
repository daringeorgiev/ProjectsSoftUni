using System;
using System.Collections.Generic;

class LongestWordInText
{
    static void Main()
    {
        //Read from console
        string[] word = Console.ReadLine().Split(' ', '.');
        
        int max = word[0].Length; //Max word
        int index = 0;            //Index of max word
        //Loop
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i].Length>max)
            {
                max = word[i].Length;
                index = i;
            }
        }
        Console.WriteLine(word[index]);
    }
}

