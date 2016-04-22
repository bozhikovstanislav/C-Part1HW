namespace CardNumber
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var card = Console.ReadLine();
            var number = 0;
            try
            {
                number = int.Parse(card);

            }
            catch (Exception)
            {
                SystemException.ReferenceEquals(card, number);

            }
            bool isCard = (1 < number && number < 11) || card == "A" || card == "Q" || card == "K" || card == "J";
            var strigCheck = "no";
            if (isCard)
            {
                strigCheck = "yes";
            }
            Console.WriteLine("{0} {1}", strigCheck, card);


        }
    }
}
