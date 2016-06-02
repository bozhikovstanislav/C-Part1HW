using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hex = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" }; //if you notice - index of array represents number in decimal.

            string input = Console.ReadLine().ToUpper(); // if enter lowercase of letter - will not be a problem
            long finale = 0;
            string temp = "";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                temp = input[i].ToString();
                for (int z = 0; z <= hex.Length - 1; z++)
                {
                    if (temp == hex[z])
                    {
                        finale += (long)((Math.Pow(16, input.Length - 1 - i)) * z);
                        break;
                    }
                }
            }
            Console.WriteLine(finale);
        }
    }
}
