
namespace Prime
{
    using System;


    class Program
    {
        static  bool isPrime(int numbr)
        {

            bool bPrime = true;
            int factor = numbr / 2;

            int i = 0;

            for (i = 2; i <= factor; i++)
            {
                if ((numbr % i) == 0)
                    bPrime = false;
            }
            return bPrime;
        }
        static void Main(string[] args)
        {
            var intNumber = Console.ReadLine();
            var number = int.Parse(intNumber);

            if (number<=0 )
            {
                Console.WriteLine("false");

            }
            if (number <= 100 && number>=2)
            {
                 Console.WriteLine(isPrime(number).ToString().ToLower());
            }
           

        }
    }
}
