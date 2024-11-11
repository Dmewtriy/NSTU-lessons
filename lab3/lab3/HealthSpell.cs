﻿using System;

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
                    throw new ArgumentOutOfRangeException("Неверное значение восстанавливающего эффекта: принимает целые значения от 1 до 4 (включительно)");
                }
            }
        }
        public override void UseSpell(Mob teammate) // прибавляем жизни к существу
        {
            teammate.Hp += indexHealth;
        }
    }
}
