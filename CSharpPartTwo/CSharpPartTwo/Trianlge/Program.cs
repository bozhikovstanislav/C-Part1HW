using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trianlge
{
    class Triangle
    {

        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        public double altitude { get; set; }
        public double angle { get; set; }

        public double Surface1()   // (a * ha) /2 
        {
            double surface = (sideA * altitude) / 2;
            return surface;
        }
        public double Surface2()  // a b c 
        {
            double p = (sideA + sideB + sideC)/2;  // eee BIg Error p must be semiperimeter witch means... (a+b+c)/2
            double surface = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return surface;
        }
        public double Surface3()
        {
           var angleR = Math.Sin(DegreeToRadian(this.angle));
            double surface =(this.sideA * this.sideB * angleR) /2 ;
            return surface;
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tester=new Triangle();

            tester.sideA = double.Parse(Console.ReadLine());

            tester.sideB = double.Parse(Console.ReadLine());

            tester.angle = double.Parse(Console.ReadLine());
            //if (tester.angle > 179)
            //{
            //    Console.ReadLine();
            //    Console.Clear();
            //}
           double surface = tester.Surface3();
            Console.WriteLine("{0:f2}", surface);
        }
    }
}
