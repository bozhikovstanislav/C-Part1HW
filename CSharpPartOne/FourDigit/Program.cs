
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace FourDigit
{
    using System;


    class Program
    {
        static void Main(string[] args)
        {
            var fourDigit = Console.ReadLine();

            if (fourDigit != null)
            {

                var isNumber = false;

                for (int i = 0; i < fourDigit.Length; i++)
                {
                    if (47 < (char) fourDigit[i] && (char) fourDigit[i] < 58)
                    {
                        isNumber = true;
                    }
                }
                if (isNumber)
                {
                    var sum = 0;
                    for (int i = 0; i < fourDigit.Length; i++)
                    {
                        var number = int.Parse(fourDigit[i].ToString());

                        sum = sum + number;

                    }
                    Console.WriteLine(sum);
                    var verersNumber = fourDigit.ToCharArray();
                    Array.Reverse(verersNumber);
                    Console.WriteLine(verersNumber);

                    var index = 0;
                    if (fourDigit.Length==4)
                    {

                        var fourNumberArray = fourDigit.ToCharArray();

                        var firstDigit = fourDigit[0];
                        var secondDigitF = fourDigit[1];
                        var tirdDigitF = fourDigit[2];
                        var lastDigit = fourDigit[3];

                        fourNumberArray[0] = lastDigit;
                        fourNumberArray[1] = firstDigit;
                        fourNumberArray[2] = secondDigitF;
                        fourNumberArray[3] = tirdDigitF;
                   
                        Console.WriteLine(fourNumberArray);

                        var fourFlipt = fourDigit.ToCharArray();

                        var secondDigit = fourFlipt[1];
                        var tirdDigit = fourFlipt[2];

                        fourFlipt[1] = tirdDigit;
                        fourFlipt[2] = secondDigit;
                        Console.WriteLine(fourFlipt);

                    }


                }
            }
        }
    }
}
