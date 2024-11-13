using System;

namespace lab3
{
    // улучшение атаки союзных карт
    internal class UpgradeAttackSpell : Spell
    {
        public override void UseSpell(Mob teammate)
        {
            teammate.Damage += Effect;
        }

    }
}
