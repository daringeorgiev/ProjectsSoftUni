using System;
using System.Collections.Generic;
class LongestAreaInArray
{
    static void Main()
    {
        Console.WriteLine("Set n:");
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        //Check
        int sum = 1;        //Sum of elements
        int maxSum = 1;     //Max Sum of elements
        int indexOfWord=0;  //Last index of max sum of elements

        for (int i = 1; i < n; i++)
        {
            if (words[i] == words[i - 1])
            {
                sum++;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    indexOfWord = (i);
                }
            }
            else
            {
                sum=1;
            }
        }

        //Print
        Console.WriteLine("\nResult:");
        Console.WriteLine(maxSum);
        for (int i =(indexOfWord-maxSum+1); i<=indexOfWord; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}

