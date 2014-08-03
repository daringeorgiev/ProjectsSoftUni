using System;

class RandomizeTheNumbers1toN
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        //Set array
        int[] num = new int[n];
        for (int i = 0; i < n; i++)
        {
            num[i] = i + 1;
        }
        //Var
        Random rnd = new Random();
        int tmp;
        //Fisher-Yates Shuffle
        for (int i = n; i > 1; i--)
        {
            // Pick random element to swap.
            int j = rnd.Next(i); // 0 <= j <= i-1
            // Swap.
            tmp = num[j];
            num[j] = num[i - 1];
            num[i - 1] = tmp;
        }
        //Print array
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(num[i]);
        }
    }
}

