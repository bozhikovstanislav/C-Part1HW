namespace QuadraticEquation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var numberA = Console.ReadLine();
            var numberB = Console.ReadLine();
            var numberC = Console.ReadLine();

            var A = double.Parse(numberA);
            var B = double.Parse(numberB);
            var C = double.Parse(numberC);

            var descriminant = Math.Pow(B, 2) - 4*A*C;
            if (descriminant > 0)
            {
                Console.WriteLine("{0:f2}\n{1:F2}", ((-B - Math.Sqrt(descriminant)) / (2 * A)), ((-B + Math.Sqrt(descriminant)) / (2 * A)));
            }
            if (descriminant == 0)
            {
                Console.WriteLine("{0:f2}", (-B / (2 * A)));
            }
            if (descriminant < 0)
            {
                Console.WriteLine("no real roots");
            }

        }
    }
}
