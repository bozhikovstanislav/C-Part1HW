
namespace ExchangeifgRATED
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var numberA = Console.ReadLine();
            var numberB = Console.ReadLine();

            var A = double.Parse(numberA);
            var B = double.Parse(numberB);

            var temp = 0D;
            if (A.CompareTo(B) > 0)
            {
                temp = B;
                B = A;
                A = temp;
                Console.WriteLine(A + " " + B);
            }
            else
            {
                Console.WriteLine(A+" "+B);
            }
         
        }
    }
}
