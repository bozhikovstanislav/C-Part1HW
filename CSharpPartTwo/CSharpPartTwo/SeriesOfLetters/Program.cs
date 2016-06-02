namespace SeriesOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
   
            string input = Console.ReadLine();
            List<char> result = new List<char>();
            result.Add(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    result.Add(input[i]);
                }
            }

            Console.WriteLine( String.Join("", result));
        }
    }
}
