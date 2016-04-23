using System;
using System.Numerics;


namespace Calculate3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var n = int.Parse(numberN);
            var numberK = Console.ReadLine();
            var k = int.Parse(numberK);
            BigInteger numinator = 1;
            BigInteger denominator = 1;
            for (int i = n; i > k; i--)
            {
                numinator *= i;
            }
            for (int i = n-k; i >= 1; i--)
            {
                denominator *= i;

            }
            Console.WriteLine(numinator/denominator);

        }
    }
}
