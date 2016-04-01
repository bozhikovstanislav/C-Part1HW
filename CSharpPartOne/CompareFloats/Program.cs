

namespace CompareFloats
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var eps = 0.000001;
            var numberOne = double.Parse(Console.ReadLine());

            var numberTwo = double.Parse(Console.ReadLine());

            var equal = "false";

            var diference = numberOne - numberTwo;

            if (Math.Abs(diference)<= eps)
            {
                equal = "true" ;

                Console.WriteLine(equal);

            }
            else
            {
               
                Console.WriteLine(equal);

            }

        }
    }
}
