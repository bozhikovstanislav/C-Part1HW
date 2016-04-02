using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace PointInCircle
{
    using System;

    class Program
    {
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

        }

        struct Circle
        {
            public Point Point { get; set; }
            public double Radius { get; set; }

            public double distance(Point point1, Point point2)
            {
                var distance =
                    Math.Sqrt((point2.X - point1.X)*(point2.X - point1.X) + (point2.Y - point1.Y)*(point2.Y - point1.Y));
                return distance;
            }
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Point center=new Point();
            center.X = 0;
            center.Y = 0;

            Circle  K =new Circle();

            K.Point = center;
            K.Radius = 2;

            var pointX = Console.ReadLine();
            var pointY = Console.ReadLine();

            Point point2Point=new Point();
            point2Point.X = double.Parse(pointX);
            point2Point.Y = double.Parse(pointY);


            var distance = K.distance(center, point2Point);
            if (distance <= K.Radius)
            {
                Console.WriteLine("yes {0:f2}", distance);

            }
            else
            {
                Console.WriteLine("no {0:f2}", distance);

            }

        }
    }
}
