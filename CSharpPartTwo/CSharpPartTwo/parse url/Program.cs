using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse_url
{
    class Program
    {
        private static string ExtractResource(string input)
        {
            int count = 0;
            int index = 0;
            string resource = string.Empty;

            while (count < 3)
            {
                index = input.IndexOf("/", index);
                index++;
                count++;
            }

            resource = input.Substring(index);

            return resource;
        }

        private static string ExtractServer(string input)
        {
            string server = string.Empty;
            int count = 0;
            int startIndex = 0;
            int endIndex = 0;

            while (count < 3)
            {
                startIndex = input.IndexOf("/");

                if (count == 1)
                {
                    startIndex = input.IndexOf("/", startIndex + 1);
                    count++;
                }
                if (count == 2)
                {
                    endIndex = input.IndexOf("/", startIndex + 1);
                    count++;
                }
                count++;
            }

            server = input.Substring(startIndex + 1, endIndex - startIndex - 1);

            return server;

        }

        private static string ExtractProtocol(string input)
        {
            int indexProtocol = 0;
            indexProtocol = input.IndexOf("://");
            string protocol = string.Empty;

            if (indexProtocol != -1)
            {
                protocol = input.Substring(0, indexProtocol - 0);
            }

            return protocol;
        }
        static void Main(string[] args)
        {
          
            string input = Console.ReadLine();
            //string input = "http://telerikacademy.com/Courses/Courses/Details/212";

            Console.WriteLine("[protocol] = {0}", ExtractProtocol(input));
            Console.WriteLine("[server] = {0}", ExtractServer(input));
            Console.WriteLine("[resource] = /{0}", ExtractResource(input));

        }
    }
}
