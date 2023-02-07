using System;

namespace MatrixProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows for both matrices: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns for both matrices: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows, columns];
            int[,] matrix2 = new int[rows, columns];
            int[,] product = new int[rows, columns];

            Console.WriteLine("Enter elements of first matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of second matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        product[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            Console.WriteLine("Product of the matrices is: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(product[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
