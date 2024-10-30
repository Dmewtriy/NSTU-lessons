using System;

namespace program_lab2
{

    internal class Program
    {
        public static void Part1()
        {
            Set<int> set = new Set<int>() { 1, 2, 3, 4};
            set += 7;
            Set<int> set2 = new Set<int>() { 3, 4, 5 }; 
               
            Console.WriteLine($"Объединение множеств: {set + set2}");
            Console.WriteLine($"Пересечение множеств: {set * set2}");
            Console.WriteLine($"Мощность множества set: {(int)set}");
            Console.WriteLine($"Размер множества set {(set ? "не больше": "меньше")} 20");
        }
        public static void Part2()
        {
            // Создание объектов
            Author author = new Author("J.K. Rowling", 59, Genres.Fantasy);
            Publishing publishing = new Publishing("Bloomsbury", "London, UK");


            Book book = new Book("Harry Potter and the Philosopher's Stone", 1997, author, publishing, Genres.Fantasy);

            Textbook textbook = new Textbook("Basic Physics", 2020, new Author("Karl F. Kuhn", 84, Genres.Scientific), new Publishing("Oxford University Press", "Oxford, UK"), "Physics");

            Magazine magazine = new Magazine("National Geographic", 2021, new Publishing("National Geographic Society", "Washington, D.C."), "Elephants");

            // Массив разнотипных объектов
            PrintedEdition[] editions = { book, textbook, magazine };

            // Вызов методов
            foreach (var edition in editions)
            {
                edition.Read();
                Console.WriteLine(edition.ToString() + "\n");
            }
        }

        static void Main()
        {
            Part1();
            Console.WriteLine();
            Console.WriteLine("Часть 2");
            Part2();
            Console.ReadLine();
        }
    }
}
