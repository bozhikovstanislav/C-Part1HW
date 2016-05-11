using System.Collections.Generic;
using System.Linq;

namespace PrimNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var nmberin = Console.ReadLine();
            var nNumber = int.Parse(nmberin);

            bool[] primeNums = new bool[nNumber];
            int count = 0;

            for (int i = 2; i < Math.Sqrt(primeNums.Length); i++)
            {
                if (primeNums[i] == false)
                {
                    for (int j = i * i; j < primeNums.Length; j += i)
                    {
                        primeNums[j] = true;
                    }
                }
            }
            List<int> primNumber = new List<int>();

            //If you want to print all prime numbers between 1 and 10 000 000, uncomment the lines below.
            for (int i = 2; i < primeNums.Length; i++)
            {
                if (!primeNums[i])
                {
                    primNumber.Add(i);

                }
                  
            }
            Console.WriteLine("{0}", primNumber.Max());

        }
    }
}
