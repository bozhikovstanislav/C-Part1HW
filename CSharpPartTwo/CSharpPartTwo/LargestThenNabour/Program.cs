using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThenNabour
{
    class Program
    {
        private static bool isLarger = false;
        private static bool CheckElement(int[] myArray, int position)
        {
            if (position > 0 && position < myArray.Length - 1)
            {
                if (myArray[position] > myArray[position + 1] && myArray[position] > myArray[position - 1])
                {
                    isLarger = true;
                }
            }
            else if (position == 0)
            {
                if (myArray[position] > myArray[position + 1])
                {
                    isLarger = true;
                }
            }
            else if (position == myArray.Length - 1)
            {
                if (myArray[position] > myArray[position - 1])
                {
                    isLarger = true;
                }
            }

            return isLarger;
        }
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();

            string[] numbersN = numbers.Split(' ').ToArray();
            int[] numsArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numsArray[i] = int.Parse(numbersN[i]);
            }


            int position = int.Parse(Console.ReadLine());

            isLarger = CheckElement(numsArray, position);

            Console.WriteLine(isLarger);
        }
    }
}
