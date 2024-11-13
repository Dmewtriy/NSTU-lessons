using System.Collections.Generic;

namespace lab3
{
    internal class AllCards
    {
        public List<Card> Cards { get; }

        public AllCards()
        {
            CardPersistence cardPersistence = new CardPersistence();
            Cards = cardPersistence.LoadFromJson();
        }
    }
}