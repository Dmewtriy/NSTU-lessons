using System;

namespace lab3
{
    //Зелье, понижающие урон картам соперника
    public class LowAttackSpell : Spell
    {
        public override void Action(Mob enemy)
        {
            if (enemy.Damage - Effect > 0)
            {
                enemy.Damage -= Effect;
            }
            else 
            { 
                enemy.Damage = 0;
            }
        }
    }
}
