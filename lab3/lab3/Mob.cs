using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Mob
    {
        private int hp;
        private int damage;
        private int price;
        private string name;
        private string history;

        public int HP
        {
            get { return hp; }
            set
            {
                if (value > 0 && value <= 10) hp = value;
                else hp = 1;
            }
        }

        public int Damage
        {
            get { return damage; }
            set
            {
                if (value > 0 && value <= 8) damage = value;
                else damage = 1;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0 && value <= 10) price = value;
                else price = 1;
            }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else name = "Mob";
            }
        }

        public virtual void Attack(Mob enemy)
        {
            enemy.HP -= Damage;
        }
    }
}
