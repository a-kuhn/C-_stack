using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name;
        public List<Card> Hand;

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public Card Draw(Deck deck)
        {
            Card addToHand = deck.Deal();
            Hand.Add(addToHand);
            Console.WriteLine($"adding {addToHand.stringVal} of {addToHand.suit} to {Name}'s hand...");
            return addToHand;
        }

        public Card Discard(int idx)
        {
            if (Hand.Count > idx)
            {
                Card discarded = Hand[idx];
                Hand.RemoveAt(idx);
                Console.WriteLine($"discarding {discarded.stringVal} of {discarded.suit}...");
                return discarded;
            }
            else { return null; }
        }

        public void ShowHand()
        {
            foreach (Card card in Hand)
            {
                Console.WriteLine($"{card.stringVal} of {card.suit}");
            }
        }
    }
}