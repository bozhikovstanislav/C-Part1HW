﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hex = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" }; // index of elements represent their value in decimal
      
            long number = long.Parse(Console.ReadLine());
            long temp = 0;
            string final = "";
            for (int i = 0; true; i++) // This can be replaced with while 
            {
                if (number < 16)
                {
                    for (int y = 0; y <= hex.Length - 1; y++)
                    {
                        if (number == y)
                        {
                            final += hex[y];
                            break;
                        }
                    }
                    break;
                }
                temp = number % 16;
                number /= 16;
                for (int z = 0; z <= hex.Length - 1; z++)
                {
                    if (temp == z)
                    {
                        final += hex[z];
                        break;
                    }
                }
            }
            //Console.WriteLine("final: " + final); //great it works
            string lastReallyFinal = "";

            for (int z = 1; z <= final.Length; z++) // must reverse ememelnts in string
            {
                lastReallyFinal += final.Substring(final.Length - z, 1); // get last digit and adds in first postion in new string
            }
            Console.WriteLine(lastReallyFinal);
        }
    }
}
