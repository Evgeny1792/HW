
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(',');
            int count = 0;

            foreach (var number in inputNumbers)
            {
                if (int.Parse(number) > 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Number of numbers greater than 0: " + count);
        }
    }

