using System;
using System.Threading;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            var width = Console.ReadLine();
            var height = Console.ReadLine();

            if (width != null && height != null)
            {

              var  weighNumber = double.Parse(width);
              var heightNumber = double.Parse(height);

              var perim = 2 * weighNumber + 2 * heightNumber;

              var area = (weighNumber*heightNumber);

                Console.WriteLine("{0:f2} {1:f2}", area,perim );


            }
        }
    }
}
