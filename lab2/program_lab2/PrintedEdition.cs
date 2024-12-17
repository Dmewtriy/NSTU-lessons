using System;

namespace program_lab2
{
    // Абстрактный класс Печатное издание
    public abstract class PrintedEdition
    {
        private string title;
        private int year;
        private Author author;
        private Publishing publishing;
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Название книги не может быть пустым.");
                }
                title = value;
            }
        }

        public int Year
        {
            get { return year; }
            private set
            {
                if (value <= 0 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Год должен быть положительным числом и не больше текущего года.");
                }
                year = value;
            }
        }

        public Author Author
        {
            get { return author; }
            private set
            {
                author = value;
            }
        }

        public Publishing Publishing
        {
            get { return publishing; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Издательство не может быть null.");
                }
                publishing = value;
            }
        }


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
