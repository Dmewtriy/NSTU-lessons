using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
