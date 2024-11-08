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
        private int indexAttack; // значение на которое понизится атака
        private int timeEffect; // время действия атаки
        private bool flag; // нужно для реализации timeEffect
        private int baseAttack; // нужно для реализации timeEffect
        public int IndexAttack
        {
            get { return indexAttack; }
            set
            {
                if (value > 0 && value < 4) 
                {
                    indexAttack = value;
                }
                else throw new ArgumentOutOfRangeException("Неверное значение понижения урона");
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
                else throw new ArgumentOutOfRangeException("Неверное значение времени действия");
            }
        }
        public void AttackEffect(Mob enemy)
        {
            if (flag == true) // такое условие нужно, чтобы урон изменился только один раз 
            { 
                baseAttack = enemy.Damage;
                if (enemy.Damage <= indexAttack)
                {
                    enemy.Damage = 1;
                }
                else enemy.Damage -= indexAttack;
                flag = false;
            }

            if (timeEffect > 0) timeEffect -= 1;
            else if (timeEffect == 0) // если время эффекта закончилось то возвращаем атаку на место
            {
                enemy.Damage = baseAttack;
            }
        }
        
    }
}
