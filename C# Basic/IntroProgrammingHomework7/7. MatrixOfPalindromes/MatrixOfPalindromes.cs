using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        //Set numbers
        string[] num = Console.ReadLine().Split(' ');
        int height = int.Parse(num[0]);
        int width = int.Parse(num[1]);
        //Matrix
        string[,] matrix = new string[height, width];
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = "" +
                  (char)('a' + row) +
                  (char)('a' + row + col) + 
                  (char)('a' + row);
            }
        }

        //Print matrix
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < width; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

