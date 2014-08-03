using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Set numbers in a single line, separated by a space:");
        string numbers = Console.ReadLine();
        string[] num = numbers.Split(' ');

        int oddProduct=1;
        int evenProduct = 1;
        int temp;

        for (int i = 0; i < num.Length; i++)
        {
            temp = int.Parse(num[i]);
            if (i % 2==0)
            {
                oddProduct *= temp;
            }
            else
            {
                evenProduct *= temp;
            }
        }
        if (oddProduct==evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("Product {0}", oddProduct);        
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("Odd product {0}", oddProduct);
            Console.WriteLine("Even product {0}", evenProduct);
        }
    }
}

