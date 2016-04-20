using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
    
            string companyName = Console.ReadLine();

            string companyAdres = Console.ReadLine();

            string phone = Console.ReadLine();

            string fax = Console.ReadLine();
            if (fax==string.Empty)
            {
                fax = "(no fax)";
            }

            string webSite = Console.ReadLine();
            if (!webSite.Contains("http"))
            {
                Console.WriteLine("Make sure you enter correct url address");
            }

            string firstName = Console.ReadLine();

            string lastName = Console.ReadLine();

            var age = uint.Parse(Console.ReadLine());

            string mangPhone = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(companyName + "\nAddress: " + companyAdres + "\nTel. " + phone + "\nFax: " + fax + "\nWeb site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3}) ", firstName, lastName, age, mangPhone);
        }
    }
}
