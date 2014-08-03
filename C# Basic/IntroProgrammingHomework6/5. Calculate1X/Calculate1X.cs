using System;

class Calculate1X
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter x:");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double num1=1;
        double num2 = 1;

        for (int i = 1; i <=n; i++)
        {
            num1 *= i;
            num2 = Math.Pow(x, i);
            sum += num1 / num2;
        }
        Console.WriteLine("{0:F5}",sum);
    }
}
