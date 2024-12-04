using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Game
    {
        private Interfaces.IGameStatus currentStatus;

      
        public Interfaces.IGameStatus CurrentStatus
        {
            get
            {
                return currentStatus;
            }
            set
            {
                if (value == null) { throw new ArgumentNullException("Текущее состояние игры не может быть null"); }
                currentStatus = value;
            }
        }
        private Player player1;
        private Player player2;
        public Player Player1
        {
            get { return player1; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Player1 cannot be null.");
                player1 = value;
            }
        }

        public Player Player2
        {
            get { return player2; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Player2 cannot be null.");
                player2 = value;
            }
        }

        public Game(Player player1, Player player2, Settings settings)
        {
            player1.settings = settings;
            player2.settings = settings;
            player1.Deck.settings = settings;
            player2.Deck.settings = settings;


            Player1 = player1;
            Player2 = player2;

            currentStatus = new StartGame();
        }

        public void StartGame()
        {
            currentStatus = new PlayerAction();
        }

        public void PerformAction(Card attacker, Mob defender)
        {
            currentStatus.Action(attacker, defender);
        }
    }
}
