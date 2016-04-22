

namespace Signe
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var numberA = Console.ReadLine();
            var numberB = Console.ReadLine();
            var numberC = Console.ReadLine();

            var a_number = double.Parse(numberA);
            var b_number = double.Parse(numberB);
            var c_number = double.Parse(numberC);

           
            var zero = a_number == 0 || b_number == 0 || c_number == 0;
            var allPlus = ((a_number > 0) && (b_number > 0) && (c_number > 0));
            var abMInus = ((a_number < 0) && (b_number < 0) && (c_number > 0));
            var bcMInus = ((a_number > 0) && (b_number < 0) && (c_number < 0));
            var acMInus = ((a_number < 0) && (b_number > 0) && (c_number < 0));
            var result = string.Empty;
            if (zero)
            {
                result = "0";
            }
            else if (allPlus || abMInus || bcMInus || acMInus)
            {
                result = "+";

            }
            else
            {
                result = "-";

            }
            Console.WriteLine("{0}", result);
        }
    }
}
