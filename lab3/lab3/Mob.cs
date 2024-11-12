using System;

namespace lab3
{
    internal abstract class Mob : Card, Interfaces.IGetDamage
    {
        private int hp;
        private int damage;

        public int Hp
        {
            get { return hp; }
            set
            {
                if (value > 0 && value <= 10) hp = value;
                else throw new ArgumentOutOfRangeException("Неверное значение здоровья");
            }
        }

        public int Damage
        {
            get { return damage; }
            set
            {
                if (value > 0 && value <= 8) damage = value;
                else throw new ArgumentOutOfRangeException("Неверное значение урона");
            }
        }

        public abstract void Attack(Mob enemy);

        public abstract void GetDamage(Archer archer);
        public abstract void GetDamage(Fly fly);
        public abstract void GetDamage(Mage mage);
        public abstract void GetDamage(Melee melee);
        public abstract void GetDamage(Tank tank);

        public override string ToString()
        {
            return base.ToString() + $" Hp-{hp} Damage-{damage}";
        }
    }
}
