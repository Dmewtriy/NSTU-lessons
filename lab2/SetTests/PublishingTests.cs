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
    public class PublishingTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            // Arrange
            string expectedName = "Publisher Inc.";
            string expectedAddress = "123 Main Street";

            // Act
            Publishing publishing = new Publishing(expectedName, expectedAddress);

            // Assert
            Assert.AreEqual(expectedName, publishing.Name, "Свойство Name должно быть корректно инициализировано.");
            Assert.AreEqual(expectedAddress, publishing.Address, "Свойство Address должно быть корректно инициализировано.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NameExceptionTest()
        {
            // Arrange & Act
            Publishing publishing = new Publishing(null, "123 Main Street");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NameTest()
        {
            // Arrange & Act
            Publishing publishing = new Publishing("", "123 Main Street");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddressExceptionTest()
        {
            // Arrange & Act
            Publishing publishing = new Publishing("Publisher Inc.", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddressTest()
        {
            // Arrange & Act
            Publishing publishing = new Publishing("Publisher Inc.", "");
        }

        [TestMethod]
        public void ToStringTest()
        {
            // Arrange
            string name = "Publisher Inc.";
            string address = "123 Main Street";
            Publishing publishing = new Publishing(name, address);

            string expectedOutput = $"Publishing: {name}, Address: {address}";

            // Act
            string result = publishing.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, result, "Метод ToString должен возвращать корректное форматирование строки.");
        }
    }
}