using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThenNabour
{
    class Program
    {
        private static bool isLarger = false;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
         
            int result = 0;
          
           long[] numsArray = new long[n];
            var numbers = Console.ReadLine();
            string[] numbersN = numbers.Split(' ').ToArray();
          

            for (int i = 0; i < numbersN.Length; i++)
            {
                numsArray[i] = long.Parse(numbersN[i]);
            }
            int count = 0;
            for (int i = 0; i < numsArray.Length; i++)
            {
                if (CheckElement(numsArray, i))
                {
                    count ++;
                    break;
                }
                else
                {
                    result = -1;
                }
            }

            if (result != -1)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(count);
            }
        }
        private static bool CheckElement(long[] myArray, int position)
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
    }
}
