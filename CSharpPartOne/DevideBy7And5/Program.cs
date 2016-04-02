using System;

namespace DevideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberString = Console.ReadLine();

            var isNumber = false;
            for (int i = 0; i < numberString.Length; i++)
            {
                if (47 < (char) numberString[i] && (char) numberString[i] <= 58)
                {
                    isNumber = true;
                }
            }
            if (isNumber)
                {
                    var number = int.Parse(numberString);

                    if (number%5 == 0 && number%7 == 0)
                    {
                        Console.WriteLine("true {0}", number);

                    }
                    else
                    {
                        Console.WriteLine("false {0}", number);

                    }
                }
            
        }
    }
}
