
namespace MoifyBit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
          
            Int64 n = Int64.Parse(Console.ReadLine());
     
            Int64 p = Int64.Parse(Console.ReadLine());
            if (p >= 0 && p < 64)
            {
                int v = Int32.Parse(Console.ReadLine());
                int mask = 1 << (Int64)p;
                bool isOne = (mask & n) == mask;

                if (isOne)
                {
                    if (v == 0)
                    {
                        Console.WriteLine(n = mask ^ n);
                    }
                    else
                    {
                        Console.WriteLine(n);
                    }
                }

                if (!isOne)
                {
                    if (v == 0)
                    {
                        Console.WriteLine(n);
                    }
                    else
                    {
                        Console.WriteLine(n = mask | n);
                    }
                }
            }
           
        }
    }
}
