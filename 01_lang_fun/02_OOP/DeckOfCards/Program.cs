using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.Shuffle();
            newDeck.Deal();
            newDeck.Deal();
            Player p1 = new Player("Buttercup");
            p1.Draw(newDeck);
            p1.Draw(newDeck);
            p1.Draw(newDeck);
            p1.Draw(newDeck);
            p1.Draw(newDeck);
            p1.ShowHand();
            p1.Discard(3);
            p1.ShowHand();
            newDeck.Reset();
        }
    }
}
