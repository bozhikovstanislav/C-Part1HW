namespace NBit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            uint n = uint.Parse(Console.ReadLine());
            int p = Int32.Parse(Console.ReadLine());
            int mask = 1 << p;
            bool temp = (n & mask) == mask;
            if (temp == true)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
