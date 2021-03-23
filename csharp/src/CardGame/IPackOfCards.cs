using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.CardGame
{
    public interface IPackOfCards : IReadOnlyCollection<ICard>
    {
        void Shuffle();

        ICard TakeCardFromTopOfPack();
    }

    public class PackOfCards : IPackOfCards
    {
        private List<Card> cards;
        public PackOfCards(List<Card> cards)
        {
            this.cards = cards;
        }

        int IReadOnlyCollection<ICard>.Count => cards.Count;

        public void Shuffle()
        {
            System.Random random = new System.Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(i, cards.Count); 
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            var topCard = cards.First();
            cards.Remove(topCard);
            return topCard;
        }

        IEnumerator<ICard> IEnumerable<ICard>.GetEnumerator()
        {
            return cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cards.GetEnumerator();
        }
    }
}
