using System.Runtime.CompilerServices;

namespace Overloaded_Methods
{
    public class Card
    {
        public Suit Suit { get; }
        public Value Value { get; }
        public string Name { get; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
            Name = $"{Value} of {Suit}";
        }

        public static bool DoesCardMatch(Card cardToCheck, Suit suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Value value)
        {
            if (cardToCheck.Value == value)
                return true;
            return false;
        }
    }
}