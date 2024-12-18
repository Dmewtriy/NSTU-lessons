using System;
using System.Collections.Generic;

namespace lab3
{
    public class Player
    {
        private string name;
        private Deck deck;
        private int coins;
        private int maxCoins = 12; // Максимальное число монет для ходов
        private bool isPlayerTurn;

        public bool IsPlayerTurn
        {
            get { return isPlayerTurn; }
            set { isPlayerTurn = value; }
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
                else if (value > maxCoins) 
                {
                    throw new ArgumentException("Превышено максимальное значение coins");
                }
                coins = value;
            }
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

        public bool Action(Card selectedCard, Mob defender)
        {
            try
            {
                selectedCard.Action(defender);
            }
            catch
            {
                return false; // hp <= 0 
            }
            return true; // hp > 0
        }

    }
}
