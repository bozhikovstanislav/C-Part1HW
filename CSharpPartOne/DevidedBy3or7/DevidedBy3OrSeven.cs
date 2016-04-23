namespace DevidedBy3or7
{
    using System;
    class DevidedBy3OrSeven
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var numberN = uint.Parse(number);

            for (int i = 1; i <= numberN; i++)
            {
                if (!(i % 3 == 0 || i % 7 == 0))
                {

                    Console.Write("{0} ", i);

                }
            }
        }
    }
}
