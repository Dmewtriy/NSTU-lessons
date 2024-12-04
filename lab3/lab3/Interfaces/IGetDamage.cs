namespace lab3.Interfaces
{
    internal interface IGetDamage
    {
        void GetDamage(Archer archer);
        void GetDamage(Fly fly);
        void GetDamage(Mage mage);
        void GetDamage(Melee melee);
        void GetDamage(Tank tank);
    }
}
