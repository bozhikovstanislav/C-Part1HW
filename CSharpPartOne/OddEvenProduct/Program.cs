namespace OddEvenProduct
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
          
            var numberToImput = int.Parse(Console.ReadLine());

            var number = Console.ReadLine();
            int[] inputNumbers=new int[numberToImput];
            string[] numbers = number.Split(' ');
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i] =int.Parse(numbers[i]);
            }
            int oddProduct = 1;
            int eventProduct = 1;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (i%2 == 0)
                {
                    oddProduct *= inputNumbers[i];

                }
                else
                {
                    eventProduct *= inputNumbers[i];

                }
            }
            if (oddProduct == eventProduct)
            {
           
                Console.WriteLine("yes {0} ", oddProduct);

            }
            else
            {
              
                Console.WriteLine("no {0} {1}", oddProduct, eventProduct);
             
            }

        }
    }
}
