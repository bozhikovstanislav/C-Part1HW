namespace Trapecoid
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            if (-500 < a && a < 500 && -555 < b && b < 500 && -555 < h && h < 500)
            {
                double v = (a + b) / 2;
                var area = h* v;
            Console.WriteLine("{0:f7}", area);

            }
         
        }
    }
}
