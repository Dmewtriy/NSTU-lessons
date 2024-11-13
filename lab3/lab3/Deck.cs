using System;
using System.Collections.Generic;

namespace lab3
{
    internal class Deck
    {
        private List<Card> deck;
        public List<Card> DeckOfCard => deck;
        public Deck()
        {
            deck = new List<Card>();
        }

        public void AddCard(Card card)
        {
            if (card == null)
                throw new ArgumentException("Неверная карта");

            if (deck.Contains(card))
                throw new ArgumentException($"Карта {card.Name} уже в колоде. Выберите другую карту.");

            if (deck.Count >= 15)
                throw new ArgumentException("Колода уже полная");

            deck.Add(card);

        }

        public bool RemoveCard(Card card)
        {
            return deck.Remove(card);
        }

        public Card TakeFirst()
        {
            if (deck.Count == 0)
                return null;

            Card card = deck[0];
            RemoveCard(card);
            return card;
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            int n = deck.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int j = rnd.Next(i, n);

                if (j != i)
                {
                    Card temp = deck[i];
                    deck[i] = deck[j];
                    deck[j] = temp;
                }
            }
        }
    }
}