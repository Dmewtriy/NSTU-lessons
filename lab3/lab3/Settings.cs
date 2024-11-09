﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab3
{
    // основная настройка игры
    internal class Settings
    {
        private int maxCoins; // максимальное число монет
        private int numMapsOnTable; //  максимальное число карт в "руках"
        private int sizeDeck; // размер колоды
        private Timer time; // таймер

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
                    throw new ArgumentOutOfRangeException("Неверное значение максимального количества монет: > 7");
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
                if (value > numMapsOnTable && value > 0 && value < 25)
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
            NumMapsOnTable = 5;
            SizeDeck = 15;
        }
        public Settings(int _maxCoins, int _numMapsOnTable, int _sizeDeck) 
        {
            MaxCoins = _maxCoins;
            NumMapsOnTable = _numMapsOnTable;
            SizeDeck = _sizeDeck;
        }

    }
}
