using System;
using System.Collections.Generic;

namespace lab3
{
    internal class Player
    {
        private int health;
        private int exp;  // опыт получаемый в конце игры при победе равный количеству убитых Mob
        private int level = 1; // уровень повышается когда exp равен 10+level*2
        private string name;
        private Deck deckFinal;
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
        public int Health
        {
            get { return health; }
            set
            {
                if (value > 0 && value <= 100) health = value;
                else throw new ArgumentOutOfRangeException("Неверное значение здоровья игрока");
            }
        }

        public Player()
        {
            deckFinal = new Deck();
            deckFinal.CreateDeck();
        }

        public int Exp { get;  }
        public int Level { get; }

        public List<Card> Deck
        {
            get
            {
                return deckFinal.DeckFinal;
            }
        }

        public void ChangeDeck()
        {
            deckFinal.ModifyDeck();
        }

        public void GetExp(int exp) // функция получает опыт в конце игры и увеличивает уровень, если опыта достаточно
        {
            if (exp > 0)
            {
                this.exp += exp;
                while (this.exp >= 10 + level * 2)
                {
                    this.exp -= (10 + level * 2);
                    level++;
                }
            }
            else throw new ArgumentOutOfRangeException("Значение для повышения опыта не может быть отрицательным");
        }

    }
}
