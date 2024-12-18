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
    public class MagazineTests
    {
        [TestMethod]
        public void ConstructorWithAuthorTest()
        {
            // Arrange
            string expectedTitle = "Tech Weekly";
            int expectedYear = 2024;
            Author expectedAuthor = new Author("John Doe", 35, Genres.Scientific);
            Publishing expectedPublishing = new Publishing("TechWorld", "San Francisco");
            string expectedTopic = "Technology";

            // Act
            Magazine magazine = new Magazine(expectedTitle, expectedYear, expectedAuthor, expectedPublishing, expectedTopic);

            // Assert
            Assert.AreEqual(expectedTitle, magazine.Title, "Название журнала должно быть корректно инициализировано.");
            Assert.AreEqual(expectedYear, magazine.Year, "Год издания должен быть корректно инициализирован.");
            Assert.AreEqual(expectedAuthor, magazine.Author, "Автор должен быть корректно инициализирован.");
            Assert.AreEqual(expectedPublishing, magazine.Publishing, "Издательство должно быть корректно инициализировано.");
            Assert.AreEqual(expectedTopic, magazine.Topic, "Тема должна быть корректно инициализирована.");
        }

        [TestMethod]
        public void ConstructorWithoutAuthorTest()
        {
            // Arrange
            string expectedTitle = "Health Monthly";
            int expectedYear = 2023;
            Publishing expectedPublishing = new Publishing("HealthPress", "New York");
            string expectedTopic = "Health";

            // Act
            Magazine magazine = new Magazine(expectedTitle, expectedYear, expectedPublishing, expectedTopic);

            // Assert
            Assert.AreEqual(expectedTitle, magazine.Title, "Название журнала должно быть корректно инициализировано.");
            Assert.AreEqual(expectedYear, magazine.Year, "Год издания должен быть корректно инициализирован.");
            Assert.IsNull(magazine.Author, "Автор должен быть равен null, если он не указан.");
            Assert.AreEqual(expectedPublishing, magazine.Publishing, "Издательство должно быть корректно инициализировано.");
            Assert.AreEqual(expectedTopic, magazine.Topic, "Тема должна быть корректно инициализирована.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TopicExceptionTest()
        {
            // Arrange
            Publishing publishing = new Publishing("ScienceDaily", "London");

            // Act
            Magazine magazine = new Magazine("Science Monthly", 2024, publishing, "");
        }

        [TestMethod]
        public void TopicTest()
        {
            // Arrange
            string initialTopic = "Nature";
            string newTopic = "Wildlife";
            Publishing publishing = new Publishing("NaturePress", "Berlin");
            Magazine magazine = new Magazine("Nature Explorer", 2023, publishing, initialTopic);

            // Act
            magazine.Topic = newTopic;

            // Assert
            Assert.AreEqual(newTopic, magazine.Topic, "Сеттер должен корректно изменять значение Topic.");
        }

        [TestMethod]
        public void ReadTest()
        {
            // Arrange
            string topic = "Fashion";
            Magazine magazine = new Magazine("Fashion Weekly", 2024, new Publishing("VoguePress", "Paris"), topic);
            string expectedOutput = $"I reading a magazine about {topic}";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                magazine.Read();

                // Assert
                string result = sw.ToString().Trim();
                Assert.AreEqual(expectedOutput, result, "Метод Read должен выводить корректное сообщение.");
            }
        }
    }
}