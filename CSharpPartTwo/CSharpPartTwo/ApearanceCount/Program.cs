using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApearanceCount
{
    class Program
    {
        private static int appearances = 0;
        private static int CountAppearances(int[] myArray, int number)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == number)
                {
                    appearances++;
                }
            }
            return appearances;
        }
        static void Main(string[] args)
        {
          
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];

         
            for (int i = 0; i < length; i++)
            {
                myArray = Console.ReadLine().Split(new string[] { " ", ",", ", " }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            }


            int number = int.Parse(Console.ReadLine());

            appearances = CountAppearances(myArray, number);

            Console.WriteLine(appearances);
        }
    }
}
