using System;

namespace _3Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            if (number != null)
            {
                
                var isNumber = false;
                
                for (int i = 0; i < number.Length; i++)
                {
                    if (47 < (char)number[i] && (char)number[i] <= 58)
                    {
                        isNumber = true;
                    }
                }
                if (isNumber)
                {
                    if (number.Length <= 20)
                    {
                        var nUmber = long.Parse(number);
                        if (nUmber > 0)
                        {
                         
                            if ((nUmber/100)%10 == 7)
                            {
                                Console.WriteLine("true");

                            }
                            else
                            {
                                Console.WriteLine("false {0}", (nUmber/100)%10);

                            }

                        }
                    }
                }

            }
        }
    }
}
