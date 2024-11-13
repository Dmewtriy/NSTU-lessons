using System;

namespace lab3
{
    // Зелье, которое увеличивает здоровье союзных карт
    internal class HealthSpell:Spell
    {
        public override void UseSpell(Mob teammate) // прибавляем жизни к существу
        {
            teammate.Hp += Effect;
        }
    }
}
