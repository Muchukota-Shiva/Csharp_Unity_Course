using System;
using ConsoleCards;

namespace Exercise11
{
    /// <summary>
    /// Exercise 11
    /// </summary>
    class Program
    {
        /// <summary>
        /// Exercise 11
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // create deck and hand
            Deck deck = new Deck();
            Card[] hand = new Card[5];

            deck.Shuffle();

            // add card, flip over, and print
            hand[0] = deck.TakeTopCard();
            hand[0].FlipOver();
            hand[0].Print();
            Console.WriteLine();

            // add another card, flip over, and print both cards
            hand[1] = deck.TakeTopCard();
            hand[1].FlipOver();
            hand[1].Print();
            hand[0].Print();
        }
    }
}
