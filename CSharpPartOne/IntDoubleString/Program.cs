using System.Diagnostics;

namespace IntDoubleString
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            

            var type = Console.ReadLine();

            var stringNumberreal = Console.ReadLine();

            switch (type)
            {
                case "integer":
                   var number = int.Parse(stringNumberreal);
                    number++;
                    Console.WriteLine(number);
                    break;
                case "real":
                  var  doubleValue = double.Parse(stringNumberreal);
                    doubleValue += 1;
                    Console.WriteLine("{0:f2}", doubleValue);
                    break;
                case "text":
                    Console.WriteLine(stringNumberreal + "*");
                    break;
            }
        }
    }
}
