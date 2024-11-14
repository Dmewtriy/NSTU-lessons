﻿namespace lab3
{
    internal class Archer : Mob, Interfaces.IGetDamage
    {
        public override void Action(Mob enemy)
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
            Hp -= melee.Damage + 2;
        }

        public override void GetDamage(Tank tank)
        {
            Hp -= tank.Damage;
        }
    }
}
