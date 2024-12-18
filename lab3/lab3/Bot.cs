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

            for (int i = 0; i < MaxNumCardOnTable; i++) 
            {
                Card randomCard = allCards[random.Next(allCards.Count)]; // Случайная карта из списка
                deck.Cards.Add(randomCard.Clone() as Card);
            }
            BotDeck = deck;
        }

        public void MakeMove(Deck playerDeck) 
        {
            Random random = new Random();
            var index = random.Next(playerDeck.Cards.Count);
            if (botDeck.Cards[index])
            Action(botDeck.Cards[index], playerDeck.Cards[index] as Mob);
        }

    }
}
