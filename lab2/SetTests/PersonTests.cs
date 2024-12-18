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
    public class PersonTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            // Arrange
            string expectedName = "John Doe";
            int expectedAge = 30;

            // Act
            Person person = new Person(expectedName, expectedAge);

            // Assert
            Assert.AreEqual(expectedName, person.Name, "Свойство Name должно быть корректно инициализировано.");
            Assert.AreEqual(expectedAge, person.Age, "Свойство Age должно быть корректно инициализировано.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NameExceptionTest()
        {
            // Arrange & Act
            Person person = new Person("", 25);
        }

        [TestMethod]
        public void NameTest()
        {
            // Arrange
            string initialName = "Jane Doe";
            string newName = "Alice Smith";
            Person person = new Person(initialName, 28);

            // Act
            person.Name = newName;

            // Assert
            Assert.AreEqual(newName, person.Name, "Свойство Name должно корректно изменяться.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgeExceptionTest()
        {
            // Arrange & Act
            Person person = new Person("John Doe", -5);
        }

        [TestMethod]
        public void AgeTest()
        {
            // Arrange
            int initialAge = 30;
            int newAge = 35;
            Person person = new Person("John Doe", initialAge);

            // Act
            person.Age = newAge;

            // Assert
            Assert.AreEqual(newAge, person.Age, "Свойство Age должно корректно изменяться.");
        }
    }
}