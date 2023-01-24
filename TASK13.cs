using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        string strNum = number.ToString();
        if (strNum.Length >= 3)
        {
            char thirdDigit = strNum[2];
            Console.WriteLine("The third digit of the number is: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("The number doesn't have a third digit.");
        }
    }
}
