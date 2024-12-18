using System;

namespace lab3
{
    // основная настройка игры
    internal class Settings
    {
        private int maxCoins; // максимальное число монет
        private int numCardOnTable; //  максимальное число карт в "руках"
        private int sizeDeck; // размер колоды
        
        public int MaxCoins
        {
            get 
            { 
                return maxCoins; 
            } 
            set 
            {
                if (value > 0)
                {
                    maxCoins = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Неверное значение максимального количества монет");
                }
            }
        }

        public int NumCardOnTable
        {
            get
            {
                return numCardOnTable;
            }
            set
            {
                if (value > 0 && value <= sizeDeck)
                {
                    numCardOnTable = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Неверное значение максимального количества карт \"в руках\"");
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
                if (value > numCardOnTable && value > 0)
                {
                    sizeDeck = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Неверное значение размера колоды");
                }
            }
        }
        public Settings()
        {
            MaxCoins = 12;
            SizeDeck = 15;
            NumCardOnTable = 5;
        }
        public Settings(int _maxCoins, int _numMapsOnTable, int _sizeDeck) 
        {
            MaxCoins = _maxCoins;
            NumCardOnTable = _numMapsOnTable;
            SizeDeck = _sizeDeck;
        }

    }
}
