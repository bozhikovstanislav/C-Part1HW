using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculation
{
    class Program
    {
        static int minimum = 0;
        static int maximum = 0;
        static decimal average = 0;
        static long sum = 0;
        static long product = 1;
        static void Main(string[] args)
        {


            var numbers = Console.ReadLine();

            string[] numbersN = numbers.Split(' ').ToArray();


            int[] numsArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numsArray[i] = int.Parse(numbersN[i]);
            }


            minimum = CalculateMinimum(numsArray);
            maximum = CalculateMaximum(numsArray);
            average = CalculateAverage(numsArray);
            sum = CalculateSum(numsArray);
            product = CalculateProduct(numsArray);

            Console.WriteLine("{0}", minimum);
            Console.WriteLine("{0}", maximum);
            Console.WriteLine("{0:F2}" ,average);
            Console.WriteLine("{0}", sum);
            Console.WriteLine("{0}", product);

        }

        private static long CalculateProduct(int[] numsArray)
        {
            for (int i = 0; i < numsArray.Length; i++)
            {
                product *= numsArray[i];
            }
            return product;
        }

        private static long CalculateSum(int[] numsArray)
        {
            for (int i = 0; i < numsArray.Length; i++)
            {
                sum += numsArray[i];
            }
            return sum;
        }

        private static decimal CalculateAverage(params int[] numsArray)
        {
            for (int i = 0; i < numsArray.Length; i++)
            {
                average += numsArray[i];
            }
            average /= numsArray.Length;

            return average;
        }

        private static int CalculateMaximum(params int[] numsArray)
        {
            int max = numsArray.Max();
            return max;
        }

        private static int CalculateMinimum(params int[] numsArray)
        {
            int min = numsArray.Min();
            return min;
        }
    }
}
