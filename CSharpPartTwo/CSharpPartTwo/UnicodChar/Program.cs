namespace UnicodChar
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
            string text = Console.ReadLine();

            //foreach (char symbol in text)
            //{
            //    Console.Write("\\u{0:X4}", (int)symbol);
            //}
            //Console.WriteLine();

           // Another variant:
            byte[] stringBytes = Encoding.Unicode.GetBytes(text);
            char[] stringChars = Encoding.Unicode.GetChars(stringBytes);
            StringBuilder builder = new StringBuilder();

            Array.ForEach<char>(stringChars, c => builder.AppendFormat("\\u{0:X4}", (int)c));
            Console.WriteLine(builder);
        }
    }
}
