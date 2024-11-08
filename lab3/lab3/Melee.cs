using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Melee : Mob
    {
        public override void Attack(Archer enemy)
        {
            base.Attack(enemy);
            enemy.Hp -= 2;
        }

        public override void Attack(Tank enemy)
        {
            base.Attack(enemy);
            enemy.Hp += 2;
        }
    }
}
