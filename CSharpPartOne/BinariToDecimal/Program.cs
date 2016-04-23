namespace BinariToDecimal
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            long sum = 0;
            for (int i = 1; i <= input.Length; i++)
            {
                var inputNumber = int.Parse(input[input.Length - i].ToString());
                sum += inputNumber*(long) Math.Pow(2, (i - 1));

            }
            Console.WriteLine(sum);


        }
    }
}
