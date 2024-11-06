using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Spell
    {
        private string name; // название зелья
        private string description; // краткое описание
        private int price; // стоимость карты(монеты)
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
                else name = "Spell";
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
                else description = "None";
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    price = value;
                }
                else price = 1;
            }
        }
    }
}
