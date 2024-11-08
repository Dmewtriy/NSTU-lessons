using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Player
    {
        private int health;
        private int exp;  // опыт получаемый в конце игры при победе равный количеству убитых Mob
        private int level = 1; // уровень повышается когда exp равен 10+level*2
        public string Name {  get; set; }
        public int Health
        {
            get { return health; }
            set
            {
                if (value > 0 && value <= 100) health = value;
                else throw new ArgumentOutOfRangeException("Неверное значение здоровья игрока");
            }
        }
        public int Exp
        {
            get { return exp; }
        }
        public int Level
        {
            get { return level; }
        }

        private List<Card> deck = new List<Card>();
        public List<Card> Deck
        {
            get
            {
                return deck;
            }
            set
            {
                if (value != null)
                {
                    if (value.Count > 0) { deck = value; }
                    else throw new ArgumentException("Колода не может быть пустой");
                }
                else throw new ArgumentNullException("Колода не может быть null");
            }
        }

        public void LevelUp(int exp) // функция получает опыт в конце игры и увеличивает уровень
        {
            this.exp += exp;
            while (this.exp>=10+level*2)
            {
                this.exp -= (10+level*2);
                level++;
            }
        }

    }
}
