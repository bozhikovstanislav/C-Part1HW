using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getLargest
{
    class Program
    {
        static int GetMaX(int [] array)
        {

            return array.Max();
        }

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            char[] m=
            {
                ' '
            };
            string[] numbersN = numbers.Split(m, StringSplitOptions.RemoveEmptyEntries);

            int[] N = new int[numbersN.Length];

            for (int i = 0; i < numbersN.Length; i++)
            {
                N[i] = int.Parse(numbersN[i]);

            }

            Console.WriteLine(GetMaX(N));
        }
    }
}
