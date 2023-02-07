using System;

namespace FindMinRowSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Enter element at row " + (i + 1) + " and column " + (j + 1) + ": ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int minRowIndex = 0;
            int minSum = int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < columns; j++)
                {
                    rowSum += array[i, j];
                }

                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minRowIndex = i;
                }
            }

            Console.WriteLine("The row with the minimum sum is row " + (minRowIndex + 1) + " with sum " + minSum);
        }
    }
}
