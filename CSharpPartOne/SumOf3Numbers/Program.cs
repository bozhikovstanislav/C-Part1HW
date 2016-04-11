namespace SumOf3Numbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());
            var numberTree = int.Parse(Console.ReadLine());
            var sum = 0;

            if ((-1000 <= numberTree && numberTree <= 1000) && (-1000 <= numberTwo && numberTwo <= 1000 )&&
                (-1000 <= numberOne && numberOne <= 1000))
            {
                sum = numberTwo + numberOne + numberTree;
               
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
