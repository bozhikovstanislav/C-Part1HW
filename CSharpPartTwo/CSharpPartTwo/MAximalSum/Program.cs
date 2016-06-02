
using System.Linq;

namespace MAximalSum
{
    using System;

    class Program
    {
        public static string RemoveWhitespace(string str)
        {
            return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
        }

        static void Main(string[] args)
        {

            string sizeInput = Console.ReadLine().TrimEnd(' ');

            string[] Sizes = sizeInput.Split(' ');

            short[][] toSearch = new short
                [int.Parse(Sizes[0])][];
            for (int row = 0; row < toSearch.GetLength(0); row++)
            {
                toSearch[row] = Console.ReadLine()
                    .Trim(' ')
                    .Split(' ')
                    .Select(num => short.Parse(num))
                    .ToArray();
            }
            int SearchSize = 3;

            short curMaxSum = short.MinValue; 
            short curSum = 0;                   


            for (int row = 0;

                row < toSearch.GetLength(0)
                - (SearchSize - 1);
         
                row++) 
            {
                for (int col = 0;
                    // Each Col
                    col < toSearch[0].GetLength(0) // Up to Size -2
                    - (SearchSize - 1);
                    col++)
                {
                    curSum = 0; 
                    for (int curRow = row;
                        curRow < row + SearchSize;
                        // Up to Grid Size
                        curRow++)
                    {
                        for (int curCol = col;
                            curCol < col + SearchSize;
                            curCol++)
                        {
                            // get the Sum
                            curSum += toSearch[curRow][curCol];
                        }
                    }
                    if (curSum > curMaxSum)
                    {
                        curMaxSum = curSum;
                    }
                }
            }
            Console.WriteLine(curMaxSum);

        }

    }
}
