using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {

            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, 1, 1);
            if (DateTime.IsLeapYear(date.Year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
