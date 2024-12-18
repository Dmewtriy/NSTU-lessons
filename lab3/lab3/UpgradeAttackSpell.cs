using System;

namespace lab3
{
    // улучшение атаки союзных карт
    public class UpgradeAttackSpell : Spell
    {
        public override void Action(Mob teammate)
        {
            teammate.Damage += Effect;
        }

    }
}
