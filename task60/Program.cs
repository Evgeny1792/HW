using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows in the 3-dimensional array: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns in the 3-dimensional array: ");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of layers in the 3-dimensional array: ");
            int layers = int.Parse(Console.ReadLine());

            int[,,] arr = new int[rows, columns, layers];

            Console.WriteLine("Enter the elements of the 3-dimensional array: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < layers; k++)
                    {
                        arr[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("The elements of the 3-dimensional array with their indices are: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < layers; k++)
                    {
                        Console.WriteLine("Element[" + i + "," + j + "," + k + "] = " + arr[i, j, k]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
