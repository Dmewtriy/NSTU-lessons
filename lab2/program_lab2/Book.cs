using System;

namespace program_lab2
{
    public enum Genres
    {
        Fiction, NonFiction, Mystery, Thriller, ScienceFiction, Fantasy, Romance, HistoricalFiction, Horror,
        Biography, AutoBiography, Memoir, Poetry, Drama, Comedy, Scientific, Other, Undefined
    }

    // Класс Книга
    public class Book : PrintedEdition
    {
        public Genres Genre { get; }
        public Book(string Title, int Year, Author Author, Publishing Publishing, Genres Genre) : base(Title, Year, Author, Publishing)
        {
            this.Genre = Genre;
        }

        public override void Read()
        {
            Console.WriteLine($"I reading Book {Title}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Genre: {Genre}";
        }
    }
}
