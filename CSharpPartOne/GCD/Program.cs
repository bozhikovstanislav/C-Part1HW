namespace GCD
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var readLine = Console.ReadLine();

            if (readLine != null)
            {
                var input = readLine.Split(' ');


                var numbera = int.Parse(input[0]);
                var numberb = int.Parse(input[1]);


                var biggerNum = Math.Max(numbera, numberb);
                for (var i = biggerNum; i > 0; i--)
                {
                    if (numbera%i == 0 && numberb%i == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
