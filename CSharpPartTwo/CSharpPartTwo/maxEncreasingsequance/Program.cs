using System;
using System.Collections.Generic;

namespace maxEncreasingsequance
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
            List<int> bestSequence = new List<int>();
            int count = 1;
            int temp = 0;
            int maxCount = 1;
            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                if (numberArray[i] < numberArray[i + 1])
                {
                    temp = i;
                    while (numberArray[temp] < numberArray[temp + 1])
                    {
                        temp++;
                        count++;

                        if (temp == numberArray.Length - 1)
                        {
                            break;
                        }
                    }

                    if (maxCount < count)
                    {
                        maxCount = count;
                        bestSequence.Clear();

                        for (int j = i; j < i + maxCount; j++)
                        {
                            bestSequence.Add(numberArray[j]);
                        }

                    }

                    count = 1;
                }
                else
                {
                    count = 1;
                }
            
            }
              Console.WriteLine(bestSequence.Count);
        }
    }
}
