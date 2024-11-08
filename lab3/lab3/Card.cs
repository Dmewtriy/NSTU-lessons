using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Card
    {
        protected int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0 && value <= 10) price = value;
                else price = 1;
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
                else name = "Card";
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
                else description = "Will be later";
            }
        }
    }
}
