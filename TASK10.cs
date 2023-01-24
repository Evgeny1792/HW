using System;

class Program {
    static void Main() {
        Console.WriteLine("Enter a three-digit number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int secondDigit = (num % 100) / 10;
        Console.WriteLine("The second digit of the number is: " + secondDigit);
    }
}
