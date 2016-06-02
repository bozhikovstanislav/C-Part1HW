using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberAsArray
{
    class Program
    {
        static int[] ConvertToArray(string number)
        {
            int[] result = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                result[number.Length - 1 - i] = number[i] - '0';
            }

            return result;
        }

        static List<int> CalculateSum(int[] firstArray, int[] secondArray)
        {
            List<int> result = new List<int>(Math.Max(firstArray.Length, secondArray.Length));

            int left = 0;

            for (int i = 0; i < result.Capacity; i++)
            {
                int num = (i < firstArray.Length ? firstArray[i] : 0) + (i < secondArray.Length ? secondArray[i] : 0) + left;
                left = num / 10;
                result.Add(num % 10);
            }

            if (left > 0) result.Add(left);

            return result;
        }

        static void PrintResult(List<int> result)
        {
            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();

            string secondNumber = Console.ReadLine();

            List<int> resultList = CalculateSum(ConvertToArray(firstNumber), ConvertToArray(secondNumber));
            PrintResult(resultList);
        }
    }
}
