namespace BonusScore
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var numberScore = Console.ReadLine();
            var score = int.Parse(numberScore);
            var result = 0;
            if (1 <= score && score <= 3)
            {
                 result = score*10;

                Console.WriteLine(result);

            }
            else if (4 <= score && score <= 6)
            {
                result = score*100;
                Console.WriteLine(result);

            }
            else if (7 <= score && score <= 9)
            {
                result = score*1000;
                Console.WriteLine(result);

            }
            else if (0 > score || score > 9)
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
