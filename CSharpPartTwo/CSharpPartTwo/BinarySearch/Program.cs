using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var nNumber = int.Parse(numberN);

            int[] numberArray = new int[nNumber];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numberArray);
            int start = 0;
            int end = numberArray.Length - 1;
            int middle = numberArray.Length / 2;
            int number = int.Parse(Console.ReadLine());

            while (start < end)
            {
                if (number < numberArray[start] || number > numberArray[end])
                {
                  
                    break;
                }
                else if (number < numberArray[middle])
                {
                    end = middle;
                    middle = (end - start) / 2 + start;

                    if (middle == end)
                    {
                        middle--;
                    }
                }
                else if (number > numberArray[middle])
                {
                    start = middle;
                    middle = (end - start) / 2 + start;

                    if (middle == start)
                    {
                        middle++;
                    }
                }
                else if (number == numberArray[middle])
                {
                    Console.WriteLine("{0}", middle);
                    break;
                }
            }
        }
    }
}
