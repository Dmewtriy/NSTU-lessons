using System.Collections.Generic;

namespace lab3
{
    public class AllCards
    {
        public List<Card> Cards { get; }

        public AllCards()
        {
            CardPersistence cardPersistence = new CardPersistence();
            Cards = cardPersistence.LoadFromJson();
        }
    }
}