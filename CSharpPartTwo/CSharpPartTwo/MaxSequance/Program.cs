using System;

namespace MaxSequance
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberN = Console.ReadLine();
            var nNumber = int.Parse(numberN);

            int[] numberArray = new int[nNumber];
           
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            int index = 0;
            int maxCount = 0;
            int tempValue = 0;
            int indexcount = 0;
            int sequence = 1;
            int maxsequence = 0;
            int element = 0;

            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                if (numberArray[i] == numberArray[i + 1])
                {
                    sequence++;

                    if (maxsequence < sequence)
                    {
                        maxsequence = sequence;
                    }
                    element = numberArray[i];
                }
                else
                {
                    sequence = 1;
                }
            }

            Console.WriteLine(maxsequence);
        }
    }
}
