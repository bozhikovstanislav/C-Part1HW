

using System.CodeDom;

namespace SumOf5
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var numberA = Console.ReadLine();
            var numberB = Console.ReadLine();
            var numberC = Console.ReadLine();
            var numberD = Console.ReadLine();
            var numberE = Console.ReadLine();

            var A = double.Parse(numberA);
            var B = double.Parse(numberB);
            var C = double.Parse(numberC);
            var D = double.Parse(numberD);
            var E = double.Parse(numberE);

            var sum = A + B + C + D + E;

            Console.WriteLine(sum);
        }
    }
}
