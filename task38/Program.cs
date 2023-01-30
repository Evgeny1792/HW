using System;

namespace ArrayDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = {1.2, 3.4, 5.6, 7.8, 9.0};
            double difference = GetDifference(numbers);
            Console.WriteLine("Difference between max and min elements: " + difference);
        }

        static double GetDifference(double[] numbers)
        {
            double max = numbers[0];
            double min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return max - min;
        }
    }
}
