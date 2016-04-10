using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = 0;
          
            try //it's like if() 
            {
                number = uint.Parse(Console.ReadLine());
            }
            catch (System.OverflowException) //if you enter number big than int32 type. Program will show "Error Overflow". Like else
            {
                Console.WriteLine("Error Overflow ");
                return;
            }
        
            int firstPosition = int.Parse(Console.ReadLine());
            int secondPosition = int.Parse(Console.ReadLine());
            int range = int.Parse(Console.ReadLine());
            if (Math.Abs(firstPosition - secondPosition) < range || firstPosition + range > 31 || secondPosition + range > 31)
            {
                Console.WriteLine("Overlapping or out of range...");
                return;
            }
            uint mask = (uint)Math.Pow(2, range) - 1; //creating perfect mask for entered range.
                                                      //Console.WriteLine(mask+"and it's presentation in bits: " + Convert.ToString(mask,2));
            uint result1 = (uint)number & (mask << firstPosition); //catch bits group from first position and assign to 'result1'
            result1 >>= firstPosition;
            uint result2 = (uint)number & (mask << secondPosition); //catch bits group from second position and assign to 'result2'
            result2 >>= secondPosition;
            number &= ~(mask << firstPosition); //set value 0 from first postion
            number &= ~(mask << secondPosition); //set value 0 from second position
            number |= (result2 << firstPosition);
            number |= (result1 << secondPosition);
            Console.WriteLine(number);
        }
    }
}
