using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Deck
    {
        protected List<Card> deckFinal;
        protected List<Mob> cardsMob;
        protected List<Spell> cardsSpell;
        public Deck()
        {
            MobPersistence mobPersistence = new MobPersistence();
            SpellPersistence spellPersistence = new SpellPersistence();
            deckFinal = new List<Card>();
            cardsMob = new List<Mob>(mobPersistence.LoadFromJson());
            cardsSpell = new List<Spell>(spellPersistence.LoadFromJson());
        }
        public List<Card> DeckFinal { get { return deckFinal; } }
        public void PrintAllCards()
        {
            int i = 1;
            Console.WriteLine("Mobs");
            foreach (Mob mob in cardsMob)
            {

                Console.WriteLine($"{i}) {mob.Name} {mob.Type} HP-{mob.Hp} Damage-{mob.Damage} Price-{mob.Price}");
                i++;
            }
            Console.WriteLine("\nSpell");
            foreach (Spell spell in cardsSpell)
            {

                Console.WriteLine($"{i}) {spell.Name} {spell.Type} Price-{spell.Price}");
                i++;
            }

        }
        
        public void CreateDeck()
        {
            Console.WriteLine("Создание колоды. Выберите карты (введите номер карты, чтобы добавить её в колоду, или 'q' для завершения):");
            PrintAllCards();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "q") break;

                if (TryAddCardToDeck(input)) continue;
                else Console.WriteLine("Некорректный ввод, попробуйте снова.");
            }

            DisplayFinalDeck();
        }

        private bool TryAddCardToDeck(string input)
        {
            int cardIndex;
            if (int.TryParse(input, out cardIndex) && cardIndex > 0 && cardIndex <= cardsMob.Count + cardsSpell.Count)
            {
                Card selectedCard; // Объявляем переменную типа Card

                if (cardIndex <= cardsMob.Count) // Если это моб
                {
                    selectedCard = cardsMob[cardIndex - 1] as Card; // Явное приведение
                }
                else // Если это заклинание
                {
                    selectedCard = cardsSpell[cardIndex - cardsMob.Count - 1] as Card; // Явное приведение
                }

                if (!deckFinal.Contains(selectedCard))
                {
                    if (deckFinal.Count < 15)
                    {
                        deckFinal.Add(selectedCard);
                        Console.WriteLine($"Добавлена карта: {selectedCard.Name}");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Невозможно добавить карту. Колода может содержать не более 15 карт.");
                    }
                }
                else
                {
                    Console.WriteLine($"Карта {selectedCard.Name} уже в колоде. Выберите другую карту.");
                }
            }
            return false;
        }

        private void DisplayFinalDeck()
        {
            Console.WriteLine("Колода создана. Выбранные карты:");
            foreach (var card in deckFinal)
            {
                Console.WriteLine(card.Name);
            }
        }

        public void ModifyDeck()
        {
            if (deckFinal.Count == 0)
            {
                Console.WriteLine("Колода пуста. Сначала создайте колоду.");
                return;
            }

            while (true)
            {
                DisplayCurrentDeck();

                Console.WriteLine("Выберите карту для удаления (введите номер карты) или 'q' для завершения:");
                string input = Console.ReadLine();
                if (input == "q") break;

                if (TryRemoveCard(input, out Card removedCard))
                {
                    Console.WriteLine($"Карта {removedCard.Name} удалена из колоды.");
                    AddNewCard();
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                }
            }

            Console.WriteLine("Изменения в колоде завершены.");
        }

        private void DisplayCurrentDeck()
        {
            Console.WriteLine("Текущая колода:");
            for (int i = 0; i < deckFinal.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {deckFinal[i].Name}");
            }
        }

        private bool TryRemoveCard(string input, out Card removedCard)
        {
            int cardIndex;
            if (int.TryParse(input, out cardIndex) && cardIndex > 0 && cardIndex <= deckFinal.Count)
            {
                removedCard = deckFinal[cardIndex - 1];
                deckFinal.RemoveAt(cardIndex - 1);
                return true;
            }
            removedCard = null;
            return false;
        }

        private void AddNewCard()
        {
            Console.WriteLine("Теперь выберите новую карту для добавления в колоду (или 'q' для завершения):");
            PrintAllCards();

            while (true)
            {
                string newCardInput = Console.ReadLine();
                if (newCardInput == "q") break;

                if (TryAddCard(newCardInput)) break;
                else Console.WriteLine("Некорректный ввод, попробуйте снова.");
            }

            DisplayCurrentDeck();
        }

        private bool TryAddCard(string input)
        {
            int newCardIndex;
            if (int.TryParse(input, out newCardIndex) && newCardIndex > 0 && newCardIndex <= cardsMob.Count + cardsSpell.Count)
            {
                Card newCard; // Объявляем переменную типа Card

                if (newCardIndex <= cardsMob.Count) // Если это моб
                {
                    newCard = cardsMob[newCardIndex - 1] as Card; // Явное приведение
                }
                else // Если это заклинание
                {
                    newCard = cardsSpell[newCardIndex - cardsMob.Count - 1] as Card; // Явное приведение
                }

                if (!deckFinal.Contains(newCard))
                {
                    if (deckFinal.Count < 15)
                    {
                        deckFinal.Add(newCard);
                        Console.WriteLine($"Добавлена карта: {newCard.Name}");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Невозможно добавить карту. Колода может содержать не более 15 карт.");
                    }
                }
                else
                {
                    Console.WriteLine($"Карта {newCard.Name} уже в колоде. Выберите другую карту.");
                }
            }
            return false;
        }

    }
}