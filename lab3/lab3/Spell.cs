using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                else throw new ArgumentOutOfRangeException("Неверное значение цены");
            }
        }
    }
}
