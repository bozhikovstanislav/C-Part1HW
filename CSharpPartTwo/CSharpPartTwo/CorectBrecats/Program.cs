using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorectBrecats
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    count++;
                }
                if (text[i] == ')')
                {
                    count--;
                }
            }
            if (count != 0)
            {
                Console.WriteLine("Incorrect");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}
