
namespace ODDEVN
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var numberString = Console.ReadLine();

            var isNumber = false;
            for (int i = 0; i < numberString.Length; i++)
            {
                if(47<(char)numberString[i]&&(char)numberString[i]<=58)
                {
                    isNumber = true;
                }
            }
            if (isNumber)
            {
                var numberToCheck = int.Parse(numberString);

                if (numberToCheck % 2 == 0)
                {
                    Console.WriteLine("even {0}", numberToCheck);
                }
                else
                {
                    Console.WriteLine("odd {0}", numberToCheck);
                }
            }
        }
    }
}
