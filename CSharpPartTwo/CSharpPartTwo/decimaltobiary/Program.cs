using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimaltobiary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long input = long.Parse(Console.ReadLine());
            string output = "";
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
            //Console.WriteLine(output);
            string final = string.Empty;
            for (int z = 1; z <= output.Length; z++) // must reverse numbers in string
            {
                final += output.Substring(output.Length - z, 1); // get last digit and adds in first postion in new string
            }
            Console.WriteLine(final);
        }
    }
}
