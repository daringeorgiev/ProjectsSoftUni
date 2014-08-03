using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n / 2; i++)
        {
            string dots = new string('.', i);
            string stars = new string('*', n - 2 * i);
            Console.WriteLine("{0}{1}{2}", dots, stars, dots);
        }

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            string dots = new string('.', i);
            string stars = new string('*', n - 2 * i);
            Console.WriteLine("{0}{1}{2}", dots, stars, dots);
        }
        //string[,] matrix=new string[n, n];

        //for (int row = 0; row <= n/2; row++)
        //{
        //    for (int col = 0; col < n; col++)
        //    {
        //        matrix[row, (col-row)]="*";
        //        //matrix[]=".";
        //    }
        //}

        //for (int i = 0; i <= n/2; i++)
        //{
        //    Console.WriteLine();
        //     for (int j = 0; j <=n; j++)
        //    {
        //        // if (matrix[i, j]!="*")
        //        //{
        //        //    matrix[i, j]=".";
        //        //}
        //        Console.WriteLine(matrix[i, j]);
        //    }
        //}
    }
}

