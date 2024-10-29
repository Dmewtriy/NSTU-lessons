using System;

namespace program_lab2
{
    // Абстрактный класс Печатное издание
    public abstract class PrintedEdition
    {
        public string Title { get;}
        public int Year { get;}
        public Author Author { get;}
        public Publishing Publishing { get;}

        public PrintedEdition(string title, int year, Author author, Publishing publishing)
        {
            Title = title;
            Year = year;
            Author = author;
            Publishing = publishing;
        }



        // Виртуальный метод для получения информации о печатном издании
        public virtual void Read()
        {
            Console.WriteLine($"I reading PrintedEdition {Title}");
        }

        // Переопределяем метод ToString
        public override string ToString()
        {
            return $"Type: {GetType().Name}, Title: {Title}, Year: {Year}, Author: {Author?.Name ?? "N/A"}, Published by: {Publishing?.Name ?? "N/A"}";
        }

        // Переопределение методов класса Object
        public override bool Equals(object obj)
        {
            if (obj is PrintedEdition edition)
            {
                return Title == edition.Title && Year == edition.Year && Author == edition.Author && Publishing == edition.Publishing;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Title, Year, Author, Publishing).GetHashCode();
        }

    }

}
