using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexsaToBin
{
    class Program
    {
        static void ConvertToDec(string input)
        {
            string[] hex = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" }; //if you notice - index of array represents number in decimal.
            // if enter lowercase of letter - will not be a problem
            long finale = 0;
            string temp = string.Empty;
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
            Console.WriteLine(ConverToBin(finale));
        }
        static long ConverToBin(long input)
        {

            string output = string.Empty;
            for (int i = 0; true; i++)
            {
                output += input % 2;
                input /= 2;
                if (input == 1)
                {
                    output += input;
                    break;
                }
            }
          
            string final = string.Empty;
            for (int z = 1; z <= output.Length; z++) // must reverse numbers in string
            {
                final += output.Substring(output.Length - z, 1); // get last digit and adds in first postion in new string
            }
            return Convert.ToInt64(final);
        }
        static void Main(string[] args)
        {
          
            string input = Console.ReadLine().ToUpper();
            ConvertToDec(input);
        }
    }
}
