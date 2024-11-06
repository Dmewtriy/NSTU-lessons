using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // основная настройка игры
    internal class Settings
    {
        private int maxCoins; // максимальное число монет
        private int numMapsOnTable; //  максимальное число карт в "руках"
        private int sizeDeck; // размер колоды

        public int MaxCoins
        {
            get 
            { 
                return maxCoins; 
            } 
            set 
            {
                if (value > 7)
                {
                    maxCoins = value;
                }
                else
                {
                    maxCoins = 12;
                }
            }
        }

        public int NumMapsOnTable
        {
            get
            {
                return numMapsOnTable;
            }
            set
            {
                if (value > 0 && value <= sizeDeck)
                {
                    numMapsOnTable = value;
                }
                else
                {
                    numMapsOnTable = 5;
                }
            }
        }

        public int SizeDeck
        {
            get
            {
                return sizeDeck;
            }
            set
            {
                if (value > numMapsOnTable && value > 0 && value < 25)
                {
                    sizeDeck = value;
                }
                else
                {
                    sizeDeck = 15;
                }
            }
        }
        public Settings() 
        {
            maxCoins = 12;
            numMapsOnTable = 5;
            sizeDeck = 15;
        }
    }
}
