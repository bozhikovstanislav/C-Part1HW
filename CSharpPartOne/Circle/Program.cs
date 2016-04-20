
using System.Globalization;
using System.Text;

namespace Circle
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            var radius = Console.ReadLine();

            double number = 0;
            if (double.TryParse(radius,out number) ==true)
            {
                Console.WriteLine("{0:F2} {1:F2}", number * 2*Math.PI, number * number * Math.PI);
                    //\u00B2 special character 
            }

           

        }
    }
}
