namespace DeckOfCkard
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var cardNumber = Console.ReadLine();
            var number = int.Parse(cardNumber);

            var cards = new string[]
            {
                "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
            };
            string[] text = new string[] { "spades,", "clubs,", "hearts,", "diamonds", };
            for (int i = 0; i < number-1; i++)
            {
                for (int k = 0; k <= text.Length - 1; k++)
                {
                    Console.Write(cards[i] + " of " + text[k] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
