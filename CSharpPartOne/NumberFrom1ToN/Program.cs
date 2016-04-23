

namespace NumberFrom1ToN
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var number_N = int.Parse(numberN);

            for (int i = 1; i <= number_N; i++)
            {
                Console.Write("{0} ", i);

            }
        }
    }
}
