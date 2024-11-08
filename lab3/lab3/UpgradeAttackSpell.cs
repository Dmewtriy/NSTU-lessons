﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // улучшение атаки союзных карт
    internal class UpgradeAttackSpell
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
                    indexUpgradeAttack = 1;
                }
            }
        }
       
        public void upgradeAttackEffect(Mob teammate)
        {
            teammate.Damage += indexUpgradeAttack;
        }

    }
}