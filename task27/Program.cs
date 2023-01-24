using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine();
        int n;
        if (int.TryParse(input, out n))
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("The sum of digits in the number is: " + sum);
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a number.");
        }
    }
}
