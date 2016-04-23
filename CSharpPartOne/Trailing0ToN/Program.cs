

using System.Numerics;

namespace Trailing0ToN
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            var sumToString = sum.ToString();
            int count = 0;

            for (int i = sumToString.Length-1; i>=0; i--)
            {
                if (sumToString[i] == '0')
                {
                    count++;
                }
                if (count != 0 && sumToString[i] != '0')
                {
                    break;
                }
            }
            Console.WriteLine(count);

        }
    }
}
