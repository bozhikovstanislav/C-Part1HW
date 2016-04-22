

namespace Sort3Numbers
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


            if (a_number > b_number)
            {
                Console.Write("{0} ",a_number);
                if (a_number > c_number)
                {


                    if (b_number > c_number)
                    {
                        Console.WriteLine("{0} {1}", b_number, c_number);

                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", c_number, b_number);

                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c_number, a_number, b_number);

                }
            }
            else
            {
                if (b_number > c_number)
                {
                    Console.Write("{0} ", b_number);
                    if (a_number > c_number)
                    {
                        Console.WriteLine("{0} {1}", a_number, c_number);

                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", c_number, a_number);

                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c_number, b_number, a_number);

                }
            }
           
        }
    }
}
