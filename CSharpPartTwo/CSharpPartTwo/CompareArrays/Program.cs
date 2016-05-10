
namespace CompareArrays
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());

            int[] arrayA = new int[numberN];
            int[] arrayB = new int[numberN];

            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arrayB.Length; i++)
            {
                arrayB[i] = int.Parse(Console.ReadLine());

            }
            var count = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] == arrayB[i])
                {
                    count++;
                }
              

            }
            if (count == arrayA.Length)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
