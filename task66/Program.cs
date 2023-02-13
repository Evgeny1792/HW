using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for M and N: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sum = GetSum(m, n);
            Console.WriteLine("Sum of numbers from M to N: " + sum);
        }

        static int GetSum(int m, int n)
        {
            if (m == n)
                return m;
            return m + GetSum(m + 1, n);
        }
    }
}

