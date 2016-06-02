using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtratSentance
{
    class Program
    {
        public static int CountWordInSentance(string text, string word)
        {
            var source = text.Split(new [] { word }, StringSplitOptions.None);
            //var matchQuery = from wordInSenatnce in source
            //                 where wordInSenatnce.ToLowerInvariant() == word.ToLowerInvariant()
            //                 select wordInSenatnce;
            int wordCount = source.Length-1;

            return wordCount;
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine(); 
            int index = 0;
            string subString = string.Empty;
            int start = 0;
            StringBuilder result = new StringBuilder();

            while (index != -1)
            {
                index = text.IndexOf('.', start);

                if (index != -1)
                {
                    subString = text.Substring(start, index - start + 1);

                    if (subString.Contains(word) && CountWordInSentance(subString,word)==1)
                    {
                        result.Append(subString);
                    }
                    start = index + 1;
                }
            }

            if (result.Length > 0)
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
