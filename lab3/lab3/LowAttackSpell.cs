using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    //Зелье, понижающие урон картам соперника
    internal class LowAttackSpell : Spell
    {
        private int indexAttack; // значение на которое понизится атака
        private int timeEffect; // время действия атаки
        //private bool flag; // нужно для реализации timeEffect
        public int IndexAttack
        {
            get { return indexAttack; }
            set
            {
                if (value > 0 && value < 4) 
                {
                    indexAttack = value;
                }
                else throw new ArgumentOutOfRangeException("Неверное значение понижения урона: принимает целые значения от 1 до 3 (включительно)");
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
                else throw new ArgumentOutOfRangeException("Неверное значение времени действия: принимает целые значения от 1 до 2 (включительно)");
            }
        }
        public override void UseSpell(Mob enemy)
        {
            int baseDamage = enemy.Damage;
            ApplyEffect(enemy);

            // что-то делаем с временем
            if (timeEffect == 0) // если время эффекта закончилось то возвращаем атаку на место
            {
                RemoveEffect(enemy, baseDamage);
            }
        }

        private void ApplyEffect(Mob enemy)
        {
            if (enemy.Damage <= indexAttack)
            {
                enemy.Damage = 1;
            }
            else
            {
                enemy.Damage -= indexAttack;
            }
        }

        private void RemoveEffect(Mob enemy, int baseDamage)
        {
            enemy.Damage = baseDamage;
        }
        
    }
}
