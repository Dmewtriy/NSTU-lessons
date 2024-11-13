using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal static class DeckPrint
    {
        public static void Print(List<Card> deck)
        {
            foreach (Card card in deck) 
            { 
                Console.WriteLine(card);
            }
        }
    }
}
