using System;
using System.Collections.Generic;

namespace lab3
{
    internal static class DeckPrint
    {
        public static void Print(List<Card> deck)
        {
            int i = 1;
            foreach (Card card in deck) 
            {
                Console.WriteLine($"{i}) {card}");
                i++;
            }
        }
    }
}
