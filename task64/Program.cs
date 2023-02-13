using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Numbers from N to 1: ");
            PrintNumbers(n);
            Console.WriteLine();
        }

        static void PrintNumbers(int n)
        {
            if (n == 0)
                return;

            Console.Write(n + " ");
            PrintNumbers(n - 1);
        }
    }
}
