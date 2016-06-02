using System;
using System.Collections.Generic;
using System.Linq;

namespace SubstringInText
{
    class Program
    {
        static void Main(string[] args)
        {

            var pater = Console.ReadLine();
            var text = Console.ReadLine();
           var textToLower = text.ToLower();
            var paterTOlower=pater.ToLower();

            int index = 0;
            int startIndex = 0;
            int count = 0;
            while (index != -1)
            {
                index = textToLower.IndexOf(paterTOlower, startIndex);
                startIndex = index + 1;

                if (index != -1)
                {
                    count++;
                }
            }Console.WriteLine(count);   
        }
    }
}
