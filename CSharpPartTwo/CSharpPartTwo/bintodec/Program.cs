using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bintodec
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            long output = 0;
            long temp;
            for (int i = 0; i < str.Length; i++)
            {
                temp = long.Parse(str[i].ToString());
                output += (long)((Math.Pow(2, (str.Length - i - 1))) * temp);
            }
            Console.WriteLine(output);
        }
    }
}
