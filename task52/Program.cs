using System;

namespace ArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows and columns in the array:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[m, n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int i = 0; i < m; i++)
                {
                    sum += array[i, j];
                }
                double average = (double)sum / m;
                Console.WriteLine("The average of column {0} is {1:F2}", j, average);
            }
        }
    }
}
