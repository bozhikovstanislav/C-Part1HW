using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReversString
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringText = Console.ReadLine();

            var arrayStrung = stringText.ToCharArray();
            var reverstArray= arrayStrung.Reverse();
            foreach (var VARIABLE in reverstArray)
            {
                Console.Write(VARIABLE);

            }
        }
    }
}
