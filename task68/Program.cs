using System;

namespace AckermannFunction
{
    class Program
    {
        static int Ackermann(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: " + Ackermann(m, n));
        }
    }
}
