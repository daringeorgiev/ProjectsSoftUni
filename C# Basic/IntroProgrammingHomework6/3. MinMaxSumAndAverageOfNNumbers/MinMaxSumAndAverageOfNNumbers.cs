using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Set n:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        //Set numbers
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Set number #{0}", (i+1));
            numbers[i] = int.Parse(Console.ReadLine());
        }
        //Set min, max, sum
        int min = numbers[0];
        int max = numbers[0];
        int sum = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            sum += numbers[i];
        }
        double avg = Convert.ToDouble(sum) / n;
        Console.WriteLine("min={0}", min);
        Console.WriteLine("max={0}", max);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}

