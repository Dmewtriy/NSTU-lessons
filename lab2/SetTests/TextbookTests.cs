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
    public class TextbookTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            // Arrange
            string expectedTitle = "Physics 101";
            int expectedYear = 2022;
            Author expectedAuthor = new Author("John Doe", 45, Genres.ScienceFiction);
            Publishing expectedPublishing = new Publishing("Education Publishing", "123 Knowledge St");
            string expectedSubject = "Physics";

            // Act
            Textbook textbook = new Textbook(expectedTitle, expectedYear, expectedAuthor, expectedPublishing, expectedSubject);

            // Assert
            Assert.AreEqual(expectedTitle, textbook.Title, "Свойство Title должно быть корректно инициализировано.");
            Assert.AreEqual(expectedYear, textbook.Year, "Свойство Year должно быть корректно инициализировано.");
            Assert.AreEqual(expectedAuthor, textbook.Author, "Свойство Author должно быть корректно инициализировано.");
            Assert.AreEqual(expectedPublishing, textbook.Publishing, "Свойство Publishing должно быть корректно инициализировано.");
            Assert.AreEqual(expectedSubject, textbook.Subject, "Свойство Subject должно быть корректно инициализировано.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SubjectTest()
        {
            // Arrange
            string invalidSubject = null;

            // Act
            new Textbook("Physics 101", 2022, null, new Publishing("Education Publishing", "123 Knowledge St"), invalidSubject);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SubjecExceptionTest()
        {
            // Arrange
            string invalidSubject = "";

            // Act
            new Textbook("Physics 101", 2022, null, new Publishing("Education Publishing", "123 Knowledge St"), invalidSubject);
        }

        [TestMethod]
        public void ReadTedt()
        {
            // Arrange
            string subject = "Mathematics";
            Textbook textbook = new Textbook("Algebra 101", 2022, null, new Publishing("Math Books", "456 Learn Ave"), subject);

            using (var consoleOutput = new System.IO.StringWriter())
            {
                Console.SetOut(consoleOutput);

                // Act
                textbook.Read();

                // Assert
                string expectedOutput = $"I reading a {subject} textbook{Environment.NewLine}";
                Assert.AreEqual(expectedOutput, consoleOutput.ToString(), "Метод Read должен выводить корректное сообщение.");
            }
        }

        [TestMethod]
        public void ToStringTest()
        {
            // Arrange
            string title = "History Basics";
            int year = 2023;
            Author author = new Author("Jane Doe", 35, Genres.HistoricalFiction);
            Publishing publishing = new Publishing("History Press", "789 Archive Rd");
            string subject = "History";

            Textbook textbook = new Textbook(title, year, author, publishing, subject);

            string expectedOutput = $"Type: Textbook, Title: {title}, Year: {year}, Author: {author.Name}, Published by: {publishing.Name}, Subject: {subject}";

            // Act
            string result = textbook.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, result, "Метод ToString должен возвращать корректное форматирование строки.");
        }
    }
}