using System.Xml;

namespace BigerOf3
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

            var temp=0D;
            if (a_number > b_number)
            {
                temp = a_number;

            }
            else
            {
                temp = b_number;

            }
            if (temp > c_number)
            {
                Console.WriteLine(temp);

            }
            else
            {
                Console.WriteLine(c_number);

            }
        }
    }
}
