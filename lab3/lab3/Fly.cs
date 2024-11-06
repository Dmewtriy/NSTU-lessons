using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Fly : Mob
    {
        public override void Attack(Fly enemy)
        {
            enemy.HP -= Damage;
        }
    }
}
