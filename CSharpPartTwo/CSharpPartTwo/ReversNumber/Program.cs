using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversNumber
{
    class Program
    {
        private static StringBuilder ReverseDigits(string number)
        {
            StringBuilder reversedNum = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNum.Append(number[i]);
            }

            return reversedNum;
        }
        static void Main(string[] args)
        {
         
            string number = Console.ReadLine();

            Console.WriteLine( ReverseDigits(number));
        }
    }
}
