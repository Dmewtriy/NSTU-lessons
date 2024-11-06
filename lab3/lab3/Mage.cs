using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Mage : Mob
    {
        public void Attack(Tank enemy)
        {
            base.Attack(enemy);
            enemy.HP -= 2;
        }

        public override void Attack(Fly enemy)
        {
            enemy.HP -= Damage;
        }
    }
}
