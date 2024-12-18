using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab3
{
    internal class Program
    {
        static void Main()
        {
            AllCards allCards = new AllCards();
            Deck deck1 = new Deck();
            Deck deck2 = new Deck();
            Player player1 = new Player() { Deck = deck1 };
            Player player2 = new Player() { Deck = deck2 };
            Game game = new Game(player1, player2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CreateGameForm(game));

        }
    }
}

