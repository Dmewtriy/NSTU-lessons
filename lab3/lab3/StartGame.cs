using System;

namespace lab3
{
    internal class StartGame : Interfaces.IGameStatus
    {
        public void Action(Card attacker, Mob defender)
        {
            throw new Exception("Вы не можете ходить во время начала игры");
        }

        public void EnterStatus()
        {
            throw new Exception("Начало игры. Подождите");
        }

        public void Waiting()
        {}
    }
}
