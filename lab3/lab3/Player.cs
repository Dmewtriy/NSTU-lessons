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
        public int Health {
            get { return health; }
            set
            {
                if (value > 0 && value <= 100) health = value;
                else health = 50;
            }
        }
        public int Exp
        {
            get { return exp; }
        }
        public int Level { 
            get { return level; }
        }
        public List<Mob> Deck { get; set; } = new List<Mob>();

        public void level_up(int exp) // функция получвет опыт в конце игры и увеличивает уровень
        {
            this.exp += exp;
            while (this.exp>=10+level*2)
            {
                this.exp = this.exp - (10+level*2);
                level++;
            }
        }

    }
}
