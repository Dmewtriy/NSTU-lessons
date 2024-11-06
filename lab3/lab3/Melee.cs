using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Melee : Mob
    {
        public void Attack(Archer enemy)
        {
            base.Attack(enemy);
            enemy.HP -= 2;
        }

        public void Attack(Tank enemy)
        {
            base.Attack(enemy);
            enemy.HP += 2;
        }
    }
}
