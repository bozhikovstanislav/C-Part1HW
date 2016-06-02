using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinShort
{
    class Program
    {
        static void Main(string[] args)
        {
        
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2)); // 
        }
    }
}
