
namespace CatalanNumber
{
    using System;


    class Program
    {
        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var n = decimal.Parse(numberN);
            decimal catalan = 1;

            for (int i = 2; i <= n; i++)
            {
                catalan *= (n + i)/i;
            }
            Console.WriteLine(Decimal.Round(catalan, 0));

        }
    }
}
