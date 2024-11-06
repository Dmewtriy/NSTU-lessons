using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Archer : Mob
    {
        public void Attack(Mage enemy)
        {
            base.Attack(enemy);
            enemy.HP -= 2;
        }

        public void Attack(Tank enemy)
        {
            base.Attack(enemy);
            enemy.HP += 2;
        }

        public override void Attack(Fly enemy)
        {
            enemy.HP -= Damage;
        }
    }
}
