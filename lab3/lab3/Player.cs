using System;
using System.Collections.Generic;

namespace lab3
{
    internal class Player
    {
        private string name;
        private Deck deck;
        private int coins;
        private int maxCoins;
        private List<Card> cardsInHand;
        public List<Card> CardsInHand => cardsInHand;
        public void TakeCard()
        {
            while (cardsInHand.Count < maxNumCardOnTable && deck.Cards.Count > 0)
                cardsInHand.Add(Deck.TakeFirst());
        }
        public int MaxCoins
        {
            get { return maxCoins; }
            set 
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Максимальное количество монет должно быть положительным");
                maxCoins = value;
            }
        }

        private int maxNumCardOnTable;
        public int MaxNumCardOnTable
        {
            get { return maxNumCardOnTable; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Максимальное количество карт \"в руке\" должно быть положительным");
                maxNumCardOnTable = value;
            }
        }

        public string Name 
        {  
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else throw new ArgumentException("Неверное имя");
            }
        }

        public int Coins
        {
            get { return coins; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательное значение переменной coins");
                }
                else if (value > MaxCoins) 
                {
                    throw new ArgumentException("Превышено максимальное значение coins");
                }
                coins = value;
            }
        }

        public Player(Deck d)
        {
            deck = d;
        }

        public Deck Deck
        {
            get
            {
                return deck;
            }
            set 
            {
                deck = value;
            }
        }

        public void Action(Card selectedCard, Mob defender)
        {
            selectedCard.Action(defender);
        }


    }
}
