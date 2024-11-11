using System;

namespace lab3
{
    internal abstract class Spell : Card
    {
        public new int Price
        {
            get { return price; }
            set
            {
                if (value > 0 && value <= 4) price = value;
                else throw new ArgumentOutOfRangeException("Неверное значение стоимости карты: принимает значения от 1 до 4 (включительно)");
            }
        }

        public abstract void UseSpell(Mob enemy);
    }
}
