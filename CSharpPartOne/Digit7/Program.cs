﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            int thirdDigit = (number / 100) % 10;
            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + thirdDigit);
            }
        }
    }
}