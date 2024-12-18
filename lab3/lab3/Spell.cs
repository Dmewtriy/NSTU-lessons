using System;

namespace lab3
{
    public abstract class Spell : Card
    {
        public new int Price
        {
            get { return price; }
            set
            {
                if (value > 0 && value <= 4) price = value;
                else throw new ArgumentOutOfRangeException("Неверное значение стоимости карты");
            }
        }

        private int effect;
        public int Effect
        {
            get { return effect; }
            set
            {
                if (value > 0 && value < 4)
                {
                    effect = value;
                }
                else throw new ArgumentOutOfRangeException("Неверное значение величины эффекта");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" Effect-{Effect}";
        }
    }
}
