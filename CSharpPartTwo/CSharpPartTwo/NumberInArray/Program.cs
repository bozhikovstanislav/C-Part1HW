using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInArray
{
    class Program
    {
        static int Number(int[] a, int k)
        {
            return a.Count(x => x == k);
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] myArray=new int[n];
            for (int i = 0; i < n; i++)
            {
                myArray = Console.ReadLine().Split(new string[] { " ", ",", ", " }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            }

            Array.Sort(myArray);
            int k = int.Parse(Console.ReadLine());
            int result = Number(myArray, k);
            Console.WriteLine("{0} appears {1} times", k, result);
        }
    }
}
