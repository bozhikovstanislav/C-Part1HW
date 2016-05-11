
using System.Collections.Generic;

namespace CharArray
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            string first = Console.ReadLine().TrimEnd(); //delete spaces afet last symbol

            string second = Console.ReadLine().TrimEnd();
            char[] myCharArray = first.ToCharArray();
            char[] mySecondArray = second.ToCharArray();
            for (int i = 0; i < myCharArray.Length; i++)
            {
               

                if ((myCharArray.Length > mySecondArray.Length) )
                {
                  

                    Console.WriteLine(">");
                    break;
                }
                else if( myCharArray.Length < mySecondArray.Length )
                {
                    Console.WriteLine("<");
                    break;
                }
                else if (myCharArray.Length == mySecondArray.Length)
                {
                    bool isEqualChar = myCharArray[i].CompareTo(mySecondArray[i]) == 0;
                    Console.WriteLine("=");
                    break;
                }
            }
        }
    }

}

