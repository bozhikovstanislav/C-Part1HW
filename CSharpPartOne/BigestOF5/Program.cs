namespace BigestOF5
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {

            var numberA = Console.ReadLine();
            var numberB = Console.ReadLine();
            var numberC = Console.ReadLine();
            var numberD = Console.ReadLine();
            var numberE = Console.ReadLine();

            double a_number = double.Parse(numberA);
            double b_number = double.Parse(numberB);
            double c_number = double.Parse(numberC);
            double d_number = double.Parse(numberD);
            double e_number = double.Parse(numberE);

            var final = 0D;
            if (a_number >= b_number && a_number >= c_number && a_number >= d_number && a_number >= e_number)
            {
                final = a_number;
            }
            if (b_number >= a_number && b_number >= c_number && b_number >= d_number && b_number >= e_number)
            {
                final = b_number;
            }
            if(c_number>=a_number&&c_number>=b_number&&c_number>=d_number&&c_number>=e_number)
            {
                final = c_number;

            }
            if (d_number >= a_number && d_number >= b_number && d_number > c_number && d_number >= e_number)
            {
                final = d_number;
            }
            if (e_number >= a_number && e_number >= b_number && e_number >= c_number && e_number >= d_number)
            {
                final = e_number;

            }
            Console.WriteLine("{0}", final);

        }
    }
}
