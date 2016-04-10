using System.Globalization;
using System.Runtime;
using System.Threading;

namespace CircleRectangle
{
    using System.Collections.Specialized;
    using System;

    public class Vector
    {
         

        public double DistanceX{ get; set; }

        public double DistanceY
        {
            get; set;
            
        }

        public Vector(double distanceX, double distanceY)
        {
            this.DistanceX = distanceX;
            this.DistanceY = distanceY;

        }

        public double DotProduct(Vector A, Vector B )
        {
            var result = A.DistanceX*B.DistanceX + A.DistanceY*B.DistanceY;
            return result;
        }
        public void RetrurnVecotor()
        {
            Console.WriteLine("{0},{1}", this.DistanceX, this.DistanceY);

        }
    }
    class Program
    {
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public double DistanceOfLine(Point A, Point B,Point unitVectorPoint)
            {
                Point Aconverted=new Point();
                Point Bconverted=new Point();
                var pointA_X = A.X*unitVectorPoint.X;
                var pointA_Y = A.Y*unitVectorPoint.Y;
                Aconverted.X = pointA_X;
                Aconverted.Y = pointA_Y;
                var pointB_X = B.X*unitVectorPoint.X;
                var pointB_Y = B.Y*unitVectorPoint.Y;
                Bconverted.X = pointB_X;
                Bconverted.Y = pointB_Y;
                var distanceResult = Distance(Aconverted, Bconverted);
                return distanceResult;
            }
        
            public double Distance(Point point1, Point point2)
            {
                var distance =
                    Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y));
                return distance;
            }
                
        }

        struct Circle
        {
            public Point Point { get; set; }
            public double Radius { get; set; }

            public double distance(Point point1, Point point2)
            {
                var distance =
                    Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y));
                return distance;
            }
        }

        struct Rectungle
        {
            public Point Pbegining { get; set; }
            public double WidPoint { get; set; }
            public double HPoint { get; set; }

            public double areaRectangle(double width, double height)
            {
                return width * height;
            }
            public bool IsPointInRectang(Point P, Point RA, Point RB, Point RC, Point RD)
            {
                var isIside = false;
                if (P.X < RA.X || P.X > RB.X || P.Y < RC.Y || P.Y > RD.Y)
                {
                    return isIside;
                }
                else
                {
                    isIside = true;
                    return isIside;
                }

            }

        }
        struct Triangle
        {
            public Point P1 { get; set; }
            public Point P2 { get; set; }
            public Point P3 { get; set; }

            public double areaTriangle(Point p1, Point p2, Point p3)
            {
                var area = Math.Abs((p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2);
                return area;
            }

          
        }
        static Point diferPoint(Point p1, Point p2)
        {
            Point result = new Point();
            result.X = p1.X - p2.X;
            result.Y = p1.Y - p2.Y;

            return result;
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Point i_unit=new Point();
            i_unit.Y = 0;
            i_unit.X = 1;

            Point j_unit=new Point();
            j_unit.Y = 1;
            j_unit.X = 0;


            Point P1_R = new Point();
            P1_R.X = 1;
            P1_R.Y = -1;

            Rectungle R = new Rectungle();
            R.Pbegining = P1_R;
            R.WidPoint = 6;
            R.HPoint = 2;

            Point P2_R = new Point();
            P2_R.X = P1_R.X;
            P2_R.Y = -(R.HPoint +(-P1_R.Y));


            Point P3_R = new Point();
            P3_R.X = P1_R.X + R.WidPoint;
            P3_R.Y = -(R.HPoint + (-P1_R.Y));

            Point P4_R = new Point();
            P4_R.X = P1_R.X + R.WidPoint;
            P4_R.Y = P1_R.Y;

            Point cercleCenter = new Point();
            cercleCenter.X = 1;
            cercleCenter.Y = 1;

            Circle cercle = new Circle();
            cercle.Point = cercleCenter;
            cercle.Radius = 1.5;

            
            Vector hightVector = new Vector(P1_R.DistanceOfLine(P1_R, P2_R,i_unit), P1_R.DistanceOfLine(P1_R, P2_R,j_unit));

            Vector widthVector=new Vector(P2_R.DistanceOfLine(P2_R,P3_R,i_unit),P2_R.DistanceOfLine(P2_R,P3_R,j_unit));

            var pointX = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            var pointY = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            if ((-1000 <= pointX && pointX <= 1000) && (-1000 <= pointY && pointY <= 1000))
            {
                {
                    Point pointTocheck = new Point();
                    pointTocheck.X = pointX;
                    pointTocheck.Y = pointY;
                    Vector PointTocheck = new Vector(pointTocheck.DistanceOfLine(pointTocheck, P1_R, i_unit),
                        pointTocheck.DistanceOfLine(pointTocheck, P1_R, j_unit));
                    bool resultTriangles = 0 <= PointTocheck.DotProduct(PointTocheck, hightVector) && 
                        PointTocheck.DotProduct(PointTocheck, hightVector) <=
                                           PointTocheck.DotProduct(hightVector, hightVector);
                    bool resultTriangles2=0<= PointTocheck.DotProduct(PointTocheck, widthVector) &&
                        PointTocheck.DotProduct(PointTocheck, widthVector) <=
                                           PointTocheck.DotProduct(widthVector, widthVector);

                    double distanseCercle = cercle.distance(cercleCenter, pointTocheck);

                    if ((resultTriangles&& resultTriangles2) && (distanseCercle <= cercle.Radius))
                    {
                        Console.WriteLine("inside circle inside rectangle");
                    }
                    if (!(resultTriangles && resultTriangles2) && (distanseCercle <= cercle.Radius))
                    {
                        Console.WriteLine("inside circle outside rectangle");
                    }
                    if (!(resultTriangles && resultTriangles2) && (distanseCercle > cercle.Radius))
                    {
                        Console.WriteLine("outside circle outside rectangle");
                    }
                    if ((resultTriangles && resultTriangles2) && (distanseCercle > cercle.Radius))
                    {
                        Console.WriteLine("outside circle inside rectangle");
                    }
                }
            }
        }
    }
}
