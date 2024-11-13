using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (card != null)
            {
                if (!deck.Contains(card))
                {
                    if (deck.Count < 15)
                    {
                        deck.Add(card);
                    }
                    else
                    {
                        throw new ArgumentException("Колода уже полная");
                    }
                }
                else
                {
                    throw new ArgumentException($"Карта {card.Name} уже в колоде. Выберите другую карту.");
                }
            }
            else
            {
                throw new ArgumentException("Неверная карта");
            }

        }

        public bool RemoveCard(Card card)
        {
            return deck.Remove(card);
        }

        public Card TakeFirst()
        {
            Card card;
            if (deck.Count != 0)
            {
                card = deck[0];
                RemoveCard(card);
                return card;
            }
            return null;
        }
    }
}