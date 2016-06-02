using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int[] myArray = Console.ReadLine().Split(new string[] { " ", ",", ", " }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("{0}", myArray.Sum());
        }
    }
}
