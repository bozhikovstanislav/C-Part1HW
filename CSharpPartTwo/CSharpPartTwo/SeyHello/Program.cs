using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyHello
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
         
            string result = Name(text);
            Console.WriteLine(result);
        }

        static string Name(string s)
        {
            s=string.Format("Hello, {0}!", s);
            return s;
            //Console.WriteLine("Hello" + s); there are several method
        }
    }
}
    

