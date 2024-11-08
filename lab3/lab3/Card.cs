using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Card
    {
        public string Type => GetType().Name;
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
    }
}
