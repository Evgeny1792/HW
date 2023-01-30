using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[8];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        int evenCount = GetEvenCount(numbers);

        Console.WriteLine("The number of even numbers in the array is: " + evenCount);
    }

    static int GetEvenCount(int[] numbers)
    {
        int count = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
