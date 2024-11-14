using System;

namespace lab3
{
    internal class WaitingForOpponentAction : Interfaces.IGameStatus
    {
        public void Action(Card attacker, Mob defender)
        {
            throw new Exception("Вы не можете атаковать. Дождитесь конца хода соперника");
        }

        public void EnterStatus()
        {
            throw new Exception("Ход соперника");
        }

        public void Waiting()
        {
            throw new Exception("Ожидание хода соперника...");
        }
    }
}
