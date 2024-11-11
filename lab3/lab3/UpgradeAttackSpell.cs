using System;

namespace lab3
{
    // улучшение атаки союзных карт
    internal class UpgradeAttackSpell : Spell
    {
        private int indexUpgradeAttack; // значение на которое повысится атака

        public int IndexUpgradeAttack
        {
            get { return indexUpgradeAttack; }
            set
            {
                if (value > 0 && value < 4)
                {
                    indexUpgradeAttack = value;
                }
                else 
                {
                    throw new ArgumentOutOfRangeException("Неверное значение повышения атаки: принимает целые значения от 1 до 3 (включительно)");
                }
            }
        }
       
        public override void UseSpell(Mob teammate)
        {
            teammate.Damage += indexUpgradeAttack;
        }

    }
}
