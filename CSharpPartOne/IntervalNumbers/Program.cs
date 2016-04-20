
namespace IntervalNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

        
            uint numA = uint.Parse(Console.ReadLine());
        
            uint numB = uint.Parse(Console.ReadLine());
            int count = 0;
            for (uint i = numA+1; i < numB; i++)
            {
                if (i % 5 == 0)
                {
                        count++;
  
                }
             
            }
            Console.WriteLine(count);
        }
    }
}
