namespace LongSequance
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1001; i++)
            {
                var number = -i * Math.Pow(-1, i - 1);
                Console.WriteLine(number);

            }

        }
    }
}
