using System;
using System.Collections.Generic;
using ConsoleCards;

namespace Exercise14
{
    /// <summary>
    /// Exercise 14
    /// </summary>
    class Program
    {
        /// <summary>
        /// Exercise 14
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // game objects
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            // shuffle the deck and deal 5 cards into the hand
            deck.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            // flip all the cards over
            foreach (Card card in hand)
            {
                card.FlipOver();
            }

            // print the hand
            foreach (Card card in hand)
            {
                card.Print();
            }
        }
    }
}
