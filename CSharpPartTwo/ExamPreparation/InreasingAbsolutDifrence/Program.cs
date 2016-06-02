using System;
using System.Linq;
namespace InreasingAbsolutDifrence
{

    class Program
    {
        //1.read input
        //2. for evry sequance do the following
            //2.1 . Calculate sequance of absolute diffrence
            //2.2. Chek if ADC is increasing
            //2.3. output of the resutlt

        static void Main()
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                    var sequence = Console.ReadLine()
                                                 .Split(' ')
                                                 .Select(long.Parse)
                                                 .ToArray();
               
                bool isIncreseang = true;
                for (int j = 1; j < sequence.Length; j++)
                {
                    var lastAbsDiff = Math.Abs(sequence[j - 2] - sequence[j - 1]);
                    var currentAbsDiss = Math.Abs(sequence[j - 1] - sequence[j]);

                    if (lastAbsDiff > currentAbsDiss || currentAbsDiss - lastAbsDiff > 1)
                    {
                        isIncreseang = false;
                        break;
                    }
                 
                }

                Console.WriteLine(isIncreseang);

            }


        }
    }
}
