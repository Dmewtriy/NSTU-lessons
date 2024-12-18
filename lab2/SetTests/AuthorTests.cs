using Microsoft.VisualStudio.TestTools.UnitTesting;
using program_lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_lab2.Tests
{
    [TestClass()]
    public class AuthorTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            // Arrange
            string expectedName = "John Doe";
            int expectedAge = 45;
            Genres expectedGenre = Genres.Fantasy;

            // Act
            Author author = new Author(expectedName, expectedAge, expectedGenre);

            // Assert
            Assert.AreEqual(expectedName, author.Name, "Имя должно быть корректно инициализировано.");
            Assert.AreEqual(expectedAge, author.Age, "Возраст должен быть корректно инициализирован.");
            Assert.AreEqual(expectedGenre, author.FavoriteGenre, "Жанр должен быть корректно инициализирован.");
        }

        [TestMethod]
        public void FavoriteGenreTest()
        {
            // Arrange
            Author author = new Author("Jane Doe", 30, Genres.Romance);
            Genres newGenre = Genres.ScienceFiction;

            // Act
            author.FavoriteGenre = newGenre;

            // Assert
            Assert.AreEqual(newGenre, author.FavoriteGenre, "Сеттер должен изменять любимый жанр.");
        }

        [TestMethod]
        public void ToStringTest()
        {
            // Arrange
            string name = "Alice";
            int age = 40;
            Genres genre = Genres.Mystery;
            Author author = new Author(name, age, genre);

            string expectedOutput = $"Person: {name}, Age: {age}, FavoriteGenre: {genre}";

            // Act
            string result = author.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, result, "Метод ToString должен возвращать корректную строку.");
        }
    }
}