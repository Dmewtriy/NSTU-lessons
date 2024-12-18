namespace lab3
{
    public class Mage : Mob, Interfaces.IGetDamage
    {
        public override void Action(Mob enemy)
        {
            enemy.GetDamage(this);
        }

        public override void GetDamage(Archer archer)
        {
            Hp -= archer.Damage + 2;
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
