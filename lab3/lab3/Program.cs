using System;
using System.CodeDom.Compiler;

namespace lab3
{
    internal class Program
    {
        static void Main()
        {
            AllCards allCards = new AllCards();
            Deck deck1 = new Deck();
            Deck deck2 = new Deck();
            foreach (Card card in allCards.Cards) 
            { 
                deck1.AddCard(card.Clone() as Card);
            }
            Player player1 = new Player(deck1);
            Player player2 = new Player(deck2);
            Settings settings = new Settings();
            Game game = new Game(player1, player2, settings);
            player1.CardsInHand.Remove(player1.Deck.Cards[0]);
            int a = 5;
        }
    }
}
