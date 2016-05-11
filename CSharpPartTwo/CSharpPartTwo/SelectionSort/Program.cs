using System;

namespace SelectionSort
{
    class Program
    {
        static void PrintNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0}", numbers[i]);

            }
        }
        static int[] Sort(params int[] numbers)
        {
            // The sorting logic:
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Loop that is operating over the un-sorted part of the array
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // Swapping the values
                    if (numbers[i] > numbers[j])
                    {
                        int helper = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = helper;
                    }
                }
            } // End of the sorting logic
            return numbers;
        }
        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var nNumber = int.Parse(numberN);

            int[] numberArray = new int[nNumber];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            Sort(numberArray);
            PrintNumbers(numberArray);
        }
    }
}
