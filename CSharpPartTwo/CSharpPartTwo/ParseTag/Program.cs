using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            {
               
                int startIndex = 0;
                int lastIndex = 0;
                StringBuilder newText = new StringBuilder();
                newText.Append(text);
                string subString = string.Empty;
                int index = 0;
                int index2 = 0;
                string clearText = string.Empty;

                while (startIndex != -1)
                {
                    startIndex = text.IndexOf("<upcase>", index);
                    index = startIndex + 1;
                    if (startIndex != -1)
                    {
                        lastIndex = text.IndexOf("</upcase>", index2);
                        index2 = lastIndex + 1;
                        subString = text.Substring(startIndex + 8, lastIndex - (startIndex + 8));
                        newText.Replace(subString, subString.ToUpper());
                    }
                }
                newText.Replace("<upcase>", "");
                newText.Replace("</upcase>", "");
                clearText = newText.ToString();
                Console.WriteLine(clearText);
            }
        }
    }
}
