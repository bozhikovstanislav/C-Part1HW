namespace Calculate
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var number_N = int.Parse(numberN);

            var number_X = Console.ReadLine();
            var x = double.Parse(number_X);
            double sum = 1;
            double factoriel = 1;
            for (int i = 1; i <= number_N; i++)
            {
                factoriel *= i;
                sum += (factoriel/Math.Pow(x,i));

            }
            Console.WriteLine("{0:F5}",sum);


        }
    }
}
