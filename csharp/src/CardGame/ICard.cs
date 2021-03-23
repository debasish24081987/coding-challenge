using System;

namespace CodingChallenge.CardGame
{
    public interface ICard : IEquatable<ICard>
    {
        Suit Suit { get; }

        Value Value { get; }
    }

    public class Card : ICard
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card()
        {

        }

        public bool Equals(ICard other)
        {
            return (this.Suit == other.Suit && this.Value == other.Value);
        }
    }
}
