using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // Зелье, которое увеличивает здоровье союзных карт
    internal class HealthSpell:Spell
    {
        private int indexHealth; // число восстанавливающего эффекта
        public int IndexHealth  
        {
            get { return indexHealth; }
            set
            {
                if (value > 0 && value < 5) 
                {
                    indexHealth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Неверное значение восстанавливающего эффекта");
                }
            }
        }
        public void HealthEffect(Mob teammate) // прибавляем жизни к существу
        {
            teammate.Hp += indexHealth;
        }
    }
}
