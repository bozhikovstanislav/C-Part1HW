using System.Globalization;
using System.Numerics;

namespace CalculateAgain
{
    using System;
    class Program
    {
       
        static void Main(string[] args)
        {
         
            var numberN = Console.ReadLine();
            var nNumber = int.Parse(numberN);
            var numberK = Console.ReadLine();
            var nKnumber = int.Parse(numberK);
            BigInteger result = 1;
        
            for (int i = nNumber; i > nKnumber; i--)
            {
                result *= i;
            }
        
            Console.WriteLine(result);

        }
    }
}
