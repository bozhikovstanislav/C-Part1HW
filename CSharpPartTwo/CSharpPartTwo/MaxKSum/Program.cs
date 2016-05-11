using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxKSum
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int n = int.Parse(Console.ReadLine());
         
            int k = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            int max = 0;
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                intList.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < k; i++)
            {
                max = intList.Max();
                sum += max;
                intList.Remove(max);
            }

            Console.WriteLine(sum);
        }
    }
}
