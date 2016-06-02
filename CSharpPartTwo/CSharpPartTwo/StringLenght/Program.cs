
namespace StringLenght
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
            StringBuilder text = new StringBuilder();

            if (input.Length > 20)
            {
                Console.WriteLine("You have entered a string, longer than 20 characters!");
            }
            if (input.Length <= 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (i <= input.Length - 1)
                    {
                        text.Append(input[i]);
                    }
                    else
                    {
                        text.Append('*');
                    }
                }

                Console.WriteLine(text.ToString());
            }
        }
    }
}
