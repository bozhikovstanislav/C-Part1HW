using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_cat_Coding
{
    class Program
    {
        //1. read input
        //1.1 extract all cat numbers from inout
        //2. convert all cat numbers to decimal
        //3. convert all decimal to base 26
        //4. join by space and print

        static ulong CatToDecimal(string catNmber)
        {
            ulong result = 0;

            foreach (char digit in catNmber)
            {
                result =(ulong)(digit - 'a') + result*21;

            }
            return result;
        }

        static string DecTo26(ulong dec)
        {
            var result = string.Empty;
            do
            {
                char digitValue =(char)('a'+ dec%26);
                // result += digitValue; concatenira w kraq na stringa
                result = digitValue +result;
                dec /= 26;
            } while (dec>0);

            return result;
        }
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(CatToDecimal).Select(DecTo26)
                .ToArray();

            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(CatToDecimal(n));

            //}
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
