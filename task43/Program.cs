using System;

namespace LineIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values of k1, b1, k2, and b2:");
            double k1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double k2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());

            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine("The intersection point is at (" + x + "," + y + ")");
        }
    }
}
