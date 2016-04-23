using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSA
{
    using System;
    class Program
    {

        static void Main(string[] args)
        {
            var numberCount = Console.ReadLine();
            uint numberTocheck = 0;
            var numberN = uint.TryParse(numberCount, out numberTocheck);
            if (numberN)
            {
                double sum = 0;
                if (1 <= numberTocheck && numberTocheck <= 1000)
                {

                    double[] numbers = new double[numberTocheck];
                    for (int i = 0; i <= numberTocheck - 1; i++)
                    {
                        numbers[i] = double.Parse(Console.ReadLine());
                    }
                    double min = numbers[0];
                    double max = numbers[0];
                    foreach (double i in numbers)
                    {
                        if (i < min)
                        {
                            min = i;
                        }
                        if (i > max)
                        {
                            max = i;
                        }
                        sum += i;
                    }
                    Console.WriteLine("min={0:f2}", min);
                    Console.WriteLine("max={0:f2}", max);
                    Console.WriteLine("sum={0:f2}", sum);
                    Console.WriteLine("avg={0:f2}", sum / numberTocheck);
                }
            }
        }
    }
}