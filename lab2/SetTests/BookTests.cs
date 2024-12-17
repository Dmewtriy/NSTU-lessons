using Microsoft.VisualStudio.TestTools.UnitTesting;
using program_lab2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_lab2.Tests
{
    [TestClass()]
    public class BookTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            // Arrange
            string expectedTitle = "War and Peace";
            int expectedYear = 1869;
            Author expectedAuthor = new Author("Leo Tolstoy", 82, Genres.HistoricalFiction);
            Publishing expectedPublishing = new Publishing("Russian Messenger", "Moscow");
            Genres expectedGenre = Genres.HistoricalFiction;

            // Act
            Book book = new Book(expectedTitle, expectedYear, expectedAuthor, expectedPublishing, expectedGenre);

            // Assert
            Assert.AreEqual(expectedTitle, book.Title, "Название книги должно быть корректно инициализировано.");
            Assert.AreEqual(expectedYear, book.Year, "Год издания должен быть корректно инициализирован.");
            Assert.AreEqual(expectedAuthor, book.Author, "Автор должен быть корректно инициализирован.");
            Assert.AreEqual(expectedPublishing, book.Publishing, "Издательство должно быть корректно инициализировано.");
            Assert.AreEqual(expectedGenre, book.Genre, "Жанр должен быть корректно инициализирован.");
        }

        [TestMethod]
        public void GenreSetTest()
        {
            // Arrange
            Book book = new Book("1984", 1949, new Author("George Orwell", 46, Genres.ScienceFiction), new Publishing("Secker & Warburg", "London"), Genres.ScienceFiction);
            Genres newGenre = Genres.Romance;

            // Act
            book.Genre = newGenre;

            // Assert
            Assert.AreEqual(newGenre, book.Genre, "Сеттер должен корректно изменять жанр.");
        }

        [TestMethod]
        public void ReadTest()
        {
            // Arrange
            Book book = new Book("The Hobbit", 1937, new Author("J.R.R. Tolkien", 81, Genres.Fantasy), new Publishing("Allen & Unwin", "London"), Genres.Fantasy);
            string expectedOutput = $"I reading Book {book.Title}";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                book.Read();

                // Assert
                string result = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput, result, "Метод Read должен выводить корректное сообщение.");
            }
        }
    }
}
