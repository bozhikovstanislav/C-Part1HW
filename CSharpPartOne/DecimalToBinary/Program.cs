using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long number = 0;
            string result=String.Empty;
            while (input>0)
            {
                number = input%2;
                input = input/2;
                result = number + result;

            }
            Console.WriteLine(result);

        }
    }
}
