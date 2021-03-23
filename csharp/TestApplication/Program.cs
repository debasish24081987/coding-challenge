using System;
using CodingChallenge.CardGame;
using System.Linq;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IPackOfCardsCreator instance = new PackOfCardsCreator();
            var packOfCards = instance.Create();
            var firstCardDetails = packOfCards.Select(x => new { x.Suit, x.Value }).FirstOrDefault();
            Console.WriteLine(firstCardDetails);
            packOfCards.Shuffle();

            var firstCardAfterShuffle= packOfCards.Select(x => new { x.Suit, x.Value }).FirstOrDefault();
            Console.WriteLine(firstCardAfterShuffle);

            packOfCards.TakeCardFromTopOfPack();
            var firstCardAfterTakingCardFromTop = packOfCards.Select(x => new { x.Suit, x.Value }).FirstOrDefault();
            Console.WriteLine(firstCardAfterTakingCardFromTop);
            Console.ReadLine();
        }
    }
}
