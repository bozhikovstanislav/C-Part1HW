namespace ReplaceTag
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

            input = input.Replace("<a href", "[our site]");
            input = input.Replace("=", "(");
            input = input.Remove(input.IndexOf("</a>"), 3);
            int index = 0;
            int forDelete = 0;

            while (index != -1)
            {
                index = input.IndexOf("[URL", index);

                if (index != -1)
                {
                    forDelete = input.IndexOf(">", index);
                    input = input.Remove(forDelete, 1);
                    input = input.Insert(forDelete, ")");
                    index++;
                }
            }
            Console.WriteLine(input);
        }
    }
}
