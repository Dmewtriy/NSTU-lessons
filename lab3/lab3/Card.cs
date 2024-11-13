using System;

namespace lab3
{
    internal abstract class Card : ICloneable
    {
        protected int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0 && value <= 10) price = value;
                else throw new ArgumentOutOfRangeException("Неверное значение цены");
            }
        }

        protected string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else throw new ArgumentException("Неверное имя");
            }
        }

        protected string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
                else throw new ArgumentException("Неверное описание");
            }
        }

        public override string ToString()
        {
            return $"{name} {GetType().Name} Price-{price}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
