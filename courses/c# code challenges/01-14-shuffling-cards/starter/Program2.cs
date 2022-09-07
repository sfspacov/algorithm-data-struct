using System;
using System.Collections.Generic;

namespace shufflingcards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to shuffle the deck and deal the top 5 cards!");
            Console.ReadKey();

            // MARK: Result
            var freshDeck = new Deck();
            var shuffledDeck = Shuffle(freshDeck.cards);

            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<string> Shuffle(List<string> deck)
        {
	    return deck;
        }
    }
}