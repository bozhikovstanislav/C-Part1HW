namespace MatrixOfNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var n = int.Parse(numberN);
            var temp = n;

            for (int i = 1; i <=n; i++)
            {
                for (int j = i; j < n+i; j++)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();

            }
        }
    }
}
