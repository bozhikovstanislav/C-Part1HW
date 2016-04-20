using System.Runtime.InteropServices;

namespace Fibonachi
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int temp1 = 0;
            int temp2 = 0;
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                if (i == 0)
                { 
                    sum = 1;
                }
               
                temp2 = temp1;
                temp1 = sum;
                Console.Write(",{0}", sum);
                sum = temp1 + temp2;
              
              
            }
        }
    }
}
