using System;

namespace OddSumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();

            Console.WriteLine("Original Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine("Sum of elements at odd positions: " + sum);
        }
    }
}
