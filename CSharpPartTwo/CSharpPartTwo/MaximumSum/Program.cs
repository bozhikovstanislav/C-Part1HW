using System;

namespace MaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var nNumber = long.Parse(numberN);

            int[] numberArray = new int[nNumber];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int maximus = 0;
            int lastindex = 0;
            int count = 0;
            int length = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                sum += numberArray[i];
                count++;
                if (sum > maximus)
                {
                    maximus = sum;
                    length = count;
                    lastindex = i;
                }
                if (sum < 0)
                {
                    sum = 0;
                    count = 0;
                }
            }
            Console.WriteLine(maximus);
        }
    }
}
