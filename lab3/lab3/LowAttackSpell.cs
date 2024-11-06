using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    //Зелье, понижающие урон картам соперника
    internal class LowAttackSpell:Spell
    {
        private int indexAttack;
        private int timeEffect;
        private bool flag;
        private int baseAttack;
        public int IndexAttack
        {
            get { return indexAttack; }
            set
            {
                if (value > 0 && value < 4) 
                {
                    indexAttack = value;
                }
                else indexAttack = 1;
            }
        }
        public int TimeEffect
        {
            get { return timeEffect; }
            set
            {
                if (value > 0 && value < 3)
                {
                    timeEffect = value;
                }
                else timeEffect = 1;
            }
        }
        public void AttackEffect(Mob opponent)
        {
            if (flag == true)
            { 
                baseAttack = opponent.Damage;
                if (opponent.Damage <= indexAttack)
                {
                    opponent.Damage = 1;
                }
                else opponent.Damage -= indexAttack;
                flag = false;
            }

            if (timeEffect > 0) timeEffect -= 1;
            else if (timeEffect == 0)
            {
                opponent.Damage = baseAttack;
            }
        }
        
    }
}
