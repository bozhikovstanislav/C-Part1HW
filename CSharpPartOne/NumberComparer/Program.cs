namespace NumberComparer
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var numberA = Console.ReadLine();
            var numberB = Console.ReadLine();

            var A = double.Parse(numberA);
            var B = double.Parse(numberB);

            Console.WriteLine(Math.Max(A, B));

        }
    }
}
