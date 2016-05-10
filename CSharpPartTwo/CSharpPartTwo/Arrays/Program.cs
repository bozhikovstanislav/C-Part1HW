using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i*5;
            }
            foreach (var VARIABLE in myArray)
            {
                Console.WriteLine(VARIABLE);
            }

        }
    }
}
