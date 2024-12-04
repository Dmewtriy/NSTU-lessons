using System;
using System.Collections.Generic;

namespace lab3
{
    internal class Player
    {
        private string name;
        private Deck deck;
        public string Name 
        {  
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else throw new ArgumentException("Неверное имя");
            }
        }

        public Player(Deck d)
        {
            deck = d;
        }

        public Deck Deck
        {
            get
            {
                return deck;
            }
        }

        public void Action(Card selectedCard, Mob defender)
        {
            selectedCard.Action(defender);
        }


    }
}
