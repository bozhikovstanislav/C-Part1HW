using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            
            uint num = uint.Parse(Console.ReadLine());
            //Console.WriteLine("Your number in bits " + Convert.ToString(num, 2).PadLeft(16, '0'));
            uint mask = 7;
            uint result1 = num & (mask << 3);
            result1 >>= 3;
            //Console.WriteLine("res1= " + Convert.ToString(result1, 2).PadLeft(16, '0'));
            uint result2 = num & (mask << 24);
            result2 >>= 24;
            //Console.WriteLine("res2= " + Convert.ToString(result2, 2).PadLeft(16, '0'));
            num &= ~(mask << 3);
            num &= ~(mask << 24);
            //Console.WriteLine("num= " + Convert.ToString(num,2).PadLeft(16,'0'));
            num |= (result2 << 3);
            num |= (result1 << 24);
            Console.WriteLine(num);

        }
    }
}
