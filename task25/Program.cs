using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string inputA = Console.ReadLine();
        int a;
        if (int.TryParse(inputA, out a))
        {
            Console.WriteLine("Enter a exponent: ");
            string inputB = Console.ReadLine();
            int b;
            if (int.TryParse(inputB, out b) && b > 0)
            {
                int result = 1;
                for (int i = 1; i <= b; i++)
                {
                    result *= a;
                }
                Console.WriteLine(a + " raised to the power of " + b + " is: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a positive number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a number.");
        }
    }
}

