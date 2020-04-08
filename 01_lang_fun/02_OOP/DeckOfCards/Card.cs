namespace DeckOfCards
{
    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;

        public Card(string stringValue, string cardSuit, int value)
        {
            stringVal = stringValue;
            suit = cardSuit;
            val = value;
        }

    }
}