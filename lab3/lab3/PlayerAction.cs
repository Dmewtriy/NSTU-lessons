using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class PlayerAction : Interfaces.IGameStatus
    {
        public void Action(Card attacker, Mob defender)
        {
            attacker.Action(defender);
        }

        public void EnterStatus()
        {
            throw new Exception("Ваш ход.");
        }

        public void Waiting()
        {
            throw new Exception("Ваш ход, атакуйте!");
        }
    }
}
