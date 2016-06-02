using System;


namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
             
                double number = double.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new Exception("Invalid number");
                }

                Console.WriteLine("{0:f3}", Math.Sqrt(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
