using System;

class SortingNumbers
{
    static void Main()
    {
        Console.WriteLine("Set n");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Set number {0}", i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        //Sort array
        Array.Sort(numbers);

        Console.WriteLine(numbers[0]);
        for (int i = 1; i < numbers.Length; i++)
        {
            //Check for similar numbers
            if (numbers[i]!=numbers[i-1]) 
            {
                Console.WriteLine(numbers[i]);
            }
            
        }
    }
}

