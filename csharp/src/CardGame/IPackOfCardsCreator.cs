using System;
using System.Collections.Generic;

namespace CodingChallenge.CardGame
{
    public interface IPackOfCardsCreator
    {
        IPackOfCards Create();
    }

    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        List<Card> cards = new List<Card>();
        public IPackOfCards Create()
        {
            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var value in Enum.GetNames(typeof(Value)))
                {
                    cards.Add(new Card
                    {
                        Suit = (Suit)Enum.Parse(typeof(Suit), suit, true),
                        Value = (Value)Enum.Parse(typeof(Value), value, true)
                    });
                }
            }

            return new PackOfCards(cards);
        }
    }
}
