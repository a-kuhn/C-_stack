using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards;

        List<string> suits = new List<string> { "clubs", "spades", "hearts", "diamonds" };
        List<string> stringVals = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        public Deck()
        {
            cards = new List<Card>();
            {
                foreach (string suit in suits)
                {
                    for (int i = 0; i < 13; i++)
                    {
                        Card newCard = new Card(stringVals[i], suit, i + 1);
                        cards.Add(newCard);
                        // Console.WriteLine($"adding a {newCard.stringVal} of {newCard.suit} to the deck");
                    }
                }
            };
        }

        public Card Deal()
        {
            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            Console.WriteLine($"Dealing a {dealtCard.stringVal} of {dealtCard.suit}...");
            return dealtCard;
        }

        public List<Card> Shuffle()
        {
            Random rand = new Random();
            Card temp;
            for (int i = 0; i < rand.Next(70, 300); i++)
            {
                int shuffleSpot = rand.Next(0, 13);
                temp = cards[shuffleSpot];
                cards.RemoveAt(shuffleSpot);
                cards.Add(temp);
            }
            return cards;
        }

        public List<Card> Reset()
        {
            cards = new List<Card>();
            {
                foreach (string suit in suits)
                {
                    for (int i = 0; i < 13; i++)
                    {
                        Card newCard = new Card(stringVals[i], suit, i + 1);
                        cards.Add(newCard);
                    }
                }
            };
            return cards;
        }
    }
}