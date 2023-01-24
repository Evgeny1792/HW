using System;

class Program
{
    static void Main(string[] args)
    {
        int day;
        Console.WriteLine("Enter a number representing a day of the week (1-7): ");
        day = Convert.ToInt32(Console.ReadLine());

        if (day == 6 || day == 7)
        {
            Console.WriteLine("It's a weekend day!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }
    }
}
