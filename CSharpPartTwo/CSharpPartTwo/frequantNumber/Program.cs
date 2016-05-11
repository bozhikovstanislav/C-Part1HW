using System;
using System.Collections.Generic;
using System.Linq;

namespace frequantNumber
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
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int number in numberArray)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, 1);
                }
                else
                {
                    dictionary[number]++;
                }
            }

            int bestValue = dictionary.FirstOrDefault(x => x.Value == dictionary.Values.Max()).Key;
            int occurences = dictionary.Values.Max();
            Console.WriteLine(bestValue + " (" + occurences + " times)");
        }
    }
}
