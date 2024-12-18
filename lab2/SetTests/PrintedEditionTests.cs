using Microsoft.VisualStudio.TestTools.UnitTesting;
using program_lab2; 
using program_lab2_tests; 
using System;


namespace program_lab2.Tests
{
    [TestClass()]
    public class PrintedEditionTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            string expectedTitle = "Sample Book";
            int expectedYear = 2023;
            Author expectedAuthor = new Author("John Doe", 40, Genres.Scientific);
            Publishing expectedPublishing = new Publishing("Publisher Inc.", "New York");

            // Act
            TestPrintedEdition edition = new TestPrintedEdition(expectedTitle, expectedYear, expectedAuthor, expectedPublishing);

            // Assert
            Assert.AreEqual(expectedTitle, edition.Title, "Свойство Title должно быть корректно инициализировано.");
            Assert.AreEqual(expectedYear, edition.Year, "Свойство Year должно быть корректно инициализировано.");
            Assert.AreEqual(expectedAuthor, edition.Author, "Свойство Author должно быть корректно инициализировано.");
            Assert.AreEqual(expectedPublishing, edition.Publishing, "Свойство Publishing должно быть корректно инициализировано.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Title_Setter_ShouldThrowException_WhenValueIsEmpty()
        {
            // Arrange
            new TestPrintedEdition("", 2023, null, new Publishing("Publisher Inc.", "New York"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Year_Setter_ShouldThrowException_WhenValueIsInvalid()
        {
            // Arrange
            new TestPrintedEdition("Sample Book", -100, null, new Publishing("Publisher Inc.", "New York"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Publishing_Setter_ShouldThrowException_WhenValueIsNull()
        {
            // Arrange
            new TestPrintedEdition("Sample Book", 2023, null, null);
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectString()
        {
            // Arrange
            string title = "Sample Book";
            int year = 2023;
            Author author = new Author("Jane Doe", 35, Genres.Fiction);
            Publishing publishing = new Publishing("Publisher Inc.", "London");

            TestPrintedEdition edition = new TestPrintedEdition(title, year, author, publishing);
            string expectedOutput = $"Type: TestPrintedEdition, Title: {title}, Year: {year}, Author: {author.Name}, Published by: {publishing.Name}";

            // Act
            string result = edition.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, result, "Метод ToString должен возвращать корректное форматирование строки.");
        }

        [TestMethod]
        public void Equals_ShouldReturnTrue_ForSameValues()
        {
            // Arrange
            Author author = new Author("John Doe", 40, Genres.Poetry);
            Publishing publishing = new Publishing("Publisher", "Paris");
            TestPrintedEdition edition1 = new TestPrintedEdition("Book Title", 2023, author, publishing);
            TestPrintedEdition edition2 = new TestPrintedEdition("Book Title", 2023, author, publishing);

            // Act & Assert
            Assert.IsTrue(edition1.Equals(edition2), "Метод Equals должен возвращать true для одинаковых объектов.");
        }

        [TestMethod]
        public void Equals_ShouldReturnFalse_ForDifferentValues()
        {
            // Arrange
            Author author1 = new Author("John Doe", 40, Genres.Poetry);
            Author author2 = new Author("Jane Doe", 30, Genres.Fiction);
            Publishing publishing = new Publishing("Publisher", "Paris");

            TestPrintedEdition edition1 = new TestPrintedEdition("Book Title", 2023, author1, publishing);
            TestPrintedEdition edition2 = new TestPrintedEdition("Another Title", 2023, author2, publishing);

            // Act & Assert
            Assert.IsFalse(edition1.Equals(edition2), "Метод Equals должен возвращать false для разных объектов.");
        }

        [TestMethod]
        public void GetHashCode_ShouldBeSame_ForSameValues()
        {
            // Arrange
            Author author = new Author("John Doe", 40, Genres.Poetry);
            Publishing publishing = new Publishing("Publisher", "Paris");

            TestPrintedEdition edition1 = new TestPrintedEdition("Book Title", 2023, author, publishing);
            TestPrintedEdition edition2 = new TestPrintedEdition("Book Title", 2023, author, publishing);

            // Act & Assert
            Assert.AreEqual(edition1.GetHashCode(), edition2.GetHashCode(), "Метод GetHashCode должен возвращать одинаковый хэш для одинаковых значений.");
        }
    }
}