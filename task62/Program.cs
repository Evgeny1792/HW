using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the matrix (n x n): ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int value = 1;
        int minRow = 0, maxRow = n - 1;
        int minCol = 0, maxCol = n - 1;
        
        while (value <= n * n)
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                matrix[minRow, i] = value;
                value++;
            }

            for (int i = minRow + 1; i <= maxRow; i++)
            {
                matrix[i, maxCol] = value;
                value++;
            }

            for (int i = maxCol - 1; i >= minCol; i--)
            {
                matrix[maxRow, i] = value;
                value++;
            }

            for (int i = maxRow - 1; i >= minRow + 1; i--)
            {
                matrix[i, minCol] = value;
                value++;
            }

            minRow++;
            minCol++;
            maxRow--;
            maxCol--;
        }

        Console.WriteLine("Spiral matrix: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
