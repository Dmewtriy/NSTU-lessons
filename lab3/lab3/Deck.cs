using System;
using System.Collections.Generic;

namespace lab3
{
    internal class Deck
    {
        private List<Card> cards;
        public List<Card> Cards => cards;
        public Deck()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            if (card == null)
                throw new ArgumentException("Неверная карта");

            if (cards.Contains(card))
                throw new ArgumentException($"Карта {card.Name} уже в колоде. Выберите другую карту.");

            if (cards.Count >= 15)
                throw new ArgumentException("Колода уже полная");

            cards.Add(card);

        }

        public bool RemoveCard(Card card)
        {
            return cards.Remove(card);
        }

        public Card TakeFirst()
        {
            if (cards.Count == 0)
                return null;

            Card card = cards[0];
            RemoveCard(card);
            return card;
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            int n = cards.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int j = rnd.Next(i, n);

                if (j != i)
                {
                    Card temp = cards[i];
                    cards[i] = cards[j];
                    cards[j] = temp;
                }
            }
        }
    }
}