namespace CircleRectangle
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

        struct Rectungle
        {
            public Point Pbegining { get; set; }
            public double WidPoint { get; set;}
            public double HPoint { get; set; }


        }
        static void Main(string[] args)
        {
            Point Xrecatngle=new Point();
            Xrecatngle.X = 1;
            Xrecatngle.Y = -1;

            Rectungle rectangle = new Rectungle();
            rectangle.Pbegining = Xrecatngle;
            rectangle.WidPoint = 6;
            rectangle.HPoint = 2;

            Point cercleCenter=new Point();

            cercleCenter.X = 1;
            cercleCenter.Y = 1;

            Circle circleOne=new Circle();
            circleOne.Point = cercleCenter;
            circleOne.Radius = 1.5;


            var pointX = double.Parse(Console.ReadLine());
            var pointY = double.Parse(Console.ReadLine());

            Point pointTocheck=new Point();
            pointTocheck.X = pointX;
            pointTocheck.Y = pointY;

            var distanceCircle = circleOne.distance(cercleCenter, pointTocheck);


        }
    }
}
