using System;

namespace ArrayElementRetriever
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows in the 2D array:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns in the 2D array:");
            int columns = int.Parse(Console.ReadLine());

            double[,] array = new double[rows, columns];

            Console.WriteLine("Enter the elements of the 2D array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the position of the element you want to retrieve (row index followed by column index, separated by a space):");
            int rowIndex = int.Parse(Console.ReadLine());
            int columnIndex = int.Parse(Console.ReadLine());

            if (rowIndex >= 0 && rowIndex < rows && columnIndex >= 0 && columnIndex < columns)
            {
                Console.WriteLine("The value of the element at position ({0}, {1}) is {2}", rowIndex, columnIndex, array[rowIndex, columnIndex]);
            }
            else
            {
                Console.WriteLine("There is no element at the specified position.");
            }
        }
    }
}
