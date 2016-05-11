using System;
namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] myArray = new char[26];

            for (int i = 0; i < 26; i++)
            {
                myArray[i] = (char)(65 + i);
            }

            string word = Console.ReadLine().ToUpper();
            int index = -2;

            for (int i = 0; i < word.Length; i++)
            {
                index = Array.IndexOf(myArray, word[i]);
                Console.WriteLine("{0}", index);
            }
        }
       
    }
}
