using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Bot:Player
    {
        private Deck botDeck;

        public Bot(Deck deck):base(deck)
        {
            
        }
        public Deck BotDeck 
        {
            get 
            { 
                return botDeck;
            }
            set
            {
                botDeck = value;
            }
        }
        public void GenerateRandomDeck()
        {
            // Генерация случайной колоды из списка всех карт
            var deck = new Deck();
            var random = new Random();
            var allCards = new AllCards().Cards;

            for (int i = 0; i < MaxNumCardOnTable; i++) // Пример: добавляем 10 случайных карт
            {
                Card randomCard = allCards[random.Next(allCards.Count)]; // Случайная карта из списка
                deck.Cards.Add(randomCard.Clone() as Card);
            }
            BotDeck = deck;
        }

        public void MakeMove(Game game, Player player) 
        {
            Random random = new Random();
            var index = random.Next(player.Deck.Cards.Count);
            game.PerformAction(botDeck.Cards[index], player.Deck.Cards[index] as Mob);
        }
    }
}
