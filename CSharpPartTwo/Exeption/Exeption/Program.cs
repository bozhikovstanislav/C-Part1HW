using System;

namespace ExeptionProject
{
  
    class Program
    {
        private static void ReadNumber(int start, int end)
        {
            Console.Write("Enter a number between {0} and {1}: ", start, end);
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number > start && number < end)
            {
                Console.WriteLine("{0} is in range.", number);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(0, 100);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
