using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTest
{
    [TestClass]
    public class CardTests
    {
        // Временный класс-наследник для тестирования
        private class TestCard : Card
        {
            public override void Action(Mob enemy) { }
        }

        [TestMethod]
        public void Test_ValidPrice()
        {
            // Arrange
            var card = new TestCard();

            // Act
            card.Price = 5;

            // Assert
            Assert.AreEqual(5, card.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_InvalidPrice_ThrowsException()
        {
            // Arrange
            var card = new TestCard();

            // Act
            card.Price = 15; // Некорректное значение
        }

        [TestMethod]
        public void Test_ValidName()
        {
            // Arrange
            var card = new TestCard();

            // Act
            card.Name = "Fireball";

            // Assert
            Assert.AreEqual("Fireball", card.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_InvalidName_ThrowsException()
        {
            // Arrange
            var card = new TestCard();

            // Act
            card.Name = ""; // Некорректное имя
        }

        [TestMethod]
        public void Test_ValidDescription()
        {
            // Arrange
            var card = new TestCard();

            // Act
            card.Description = "A powerful fireball spell.";

            // Assert
            Assert.AreEqual("A powerful fireball spell.", card.Description);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_InvalidDescription_ThrowsException()
        {
            // Arrange
            var card = new TestCard();

            // Act
            card.Description = "   "; // Некорректное описание
        }

        [TestMethod]
        public void Test_Clone_CreatesCopy()
        {
            // Arrange
            var card = new TestCard
            {
                Price = 5,
                Name = "Fireball",
                Description = "A powerful fireball spell."
            };

            // Act
            var clonedCard = (Card)card.Clone();

            // Assert
            Assert.AreNotSame(card, clonedCard); // Объекты должны быть разными
            Assert.AreEqual(card.Price, clonedCard.Price);
            Assert.AreEqual(card.Name, clonedCard.Name);
            Assert.AreEqual(card.Description, clonedCard.Description);
        }

        [TestMethod]
        public void Test_ToString_ReturnsExpectedFormat()
        {
            // Arrange
            var card = new TestCard
            {
                Price = 8,
                Name = "Lightning",
                Description = "A spell that strikes with lightning."
            };

            // Act
            var result = card.ToString();

            // Assert
            Assert.AreEqual("Lightning TestCard Price-8", result);
        }
    }
}