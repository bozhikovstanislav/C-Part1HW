using System;
using System.Globalization;
using System.Threading;

namespace MoonWight
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            var manWiegh = Console.ReadLine();

           double  number;
            var manEarthWeigth = double.TryParse(manWiegh, out number);
            if (0 < number && number < 1000)
            {
                if (manEarthWeigth)
                {
                    var weightOnMoon = number * 0.17;
                    Console.WriteLine("{0:f3}", weightOnMoon);
                }
               
            }
        }
    }
}
