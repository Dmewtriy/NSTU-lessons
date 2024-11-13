using System;

namespace lab3
{
    //Зелье, понижающие урон картам соперника
    internal class LowAttackSpell : Spell
    {
        private int timeEffect; // время действия атаки
        //private bool flag; // нужно для реализации timeEffect
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
            if (enemy.Damage <= Effect)
            {
                enemy.Damage = 1;
            }
            else
            {
                enemy.Damage -= Effect;
            }
        }

        private void RemoveEffect(Mob enemy, int baseDamage)
        {
            enemy.Damage = baseDamage;
        }
        
    }
}
