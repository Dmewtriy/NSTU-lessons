using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Game
    {
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

        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
    }
}
