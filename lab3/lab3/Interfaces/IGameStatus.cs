using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Interfaces
{
    internal interface IGameStatus
    {
        void EnterStatus();
        void Action(Card attacker, Mob defender);
        void Waiting();
    }
}
