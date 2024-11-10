using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Melee : Mob, Interfaces.IGetDamage
    {
        public override void Attack(Mob enemy)
        {
            enemy.GetDamage(this);
        }

        public override void GetDamage(Archer archer)
        {
            Hp -= archer.Damage;
        }

        public override void GetDamage(Fly fly)
        {
            Hp -= fly.Damage;
        }

        public override void GetDamage(Mage mage)
        {
            Hp -= mage.Damage;
        }

        public override void GetDamage(Melee melee)
        {
            Hp -= melee.Damage;
        }

        public override void GetDamage(Tank tank)
        {
            Hp -= tank.Damage;
        }
    }
}
