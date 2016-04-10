namespace TirdBit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            int number = ushort.Parse(Console.ReadLine());
            if (number > 0)
            {
                int p = 3;
                int mask = 1 << p;
                int nAndMask = number & mask;
                int bit = nAndMask >> p;
                Console.WriteLine(bit);
            }
    
        }
    }
}
