﻿using System;

namespace lab3
{
    // Зелье, которое увеличивает здоровье союзных карт
    internal class HealthSpell:Spell
    {
        public override void Action(Mob teammate) // прибавляем жизни к существу
        {
            teammate.Hp += Effect;
        }
    }
}
