using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows in the matrix: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns in the matrix: ");
        int n = int.Parse(Console.ReadLine());

        double[,] matrix = new double[m, n];
        Random rnd = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
