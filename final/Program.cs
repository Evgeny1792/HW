using System;

class Program
{
    static void Main(string[] args)
    {
        // Введите массив строк
        string[] inputStrings = { "hello", "world", "my", "name", "is", "GeekBrains" };

        // Создайте новый массив для строк длиной не более 3 символов
        string[] outputStrings = new string[inputStrings.Length];
        int outputIndex = 0;

        // Пройдитесь по каждой строке и добавьте её в новый массив, если её длина меньше или равна 3 символам
        foreach (string inputString in inputStrings)
        {
            if (inputString.Length <= 3)
            {
                outputStrings[outputIndex] = inputString;
                outputIndex++;
            }
        }

        // Выведите результаты
        Console.WriteLine("Input strings: {0}", string.Join(", ", inputStrings));
        Console.WriteLine("Output strings: {0}", string.Join(", ", outputStrings));
    }
}
