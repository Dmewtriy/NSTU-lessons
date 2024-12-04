using System;
using System.Collections.Generic;

namespace lab3
{
    internal class Player
    {
        private string name;
        private Deck deck;
        private Settings settings;
        private int coins;
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
                else if (value > settings.MaxCoins) 
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
        }

        public void Action(Card selectedCard, Mob defender)
        {
            selectedCard.Action(defender);
        }


    }
}
