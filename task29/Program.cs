using System;

class Program
{
    static void Main()
    {
        int[] array = new int[8]; // Declaring an array of 8 elements
        Console.WriteLine("Enter 8 numbers:");
        for (int i = 0; i < 8; i++)
        {
            array[i] = int.Parse(Console.ReadLine()); // Assign user input to each element of the array
        }
        Console.Write("The elements of the array are: [");
        for (int i = 0; i < 8; i++)
        {
            if (i == 7) {
              Console.Write(array[i]);
            } else {
              Console.Write(array[i] + ", ");
            }
        }
        Console.Write("]");
    }
}
