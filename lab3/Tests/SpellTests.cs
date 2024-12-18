using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardTest
{
    [TestClass()]
    public class SpellTests
    {
        public class SpTest : Spell 
        {
            
            public override void Action(Mob enemy)
            {

            }

        }

        [TestMethod()]
        public void EffectTest()
        {
            // Arrange
            var spell = new SpTest();
            int effect = 2;
            // Act
            spell.Effect = effect;

            // Assert
            Assert.AreEqual(2, spell.Effect);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod()]
        public void EffectExceptionTest()
        {
            // Arrange
            var spell = new SpTest();
            int effect = 5;
            // Act
            spell.Effect = effect;
        }

        [TestMethod()]
        public void PriceTest()
        {
            // Arrange
            var spell = new SpTest();
            int price = 2;
            // Act
            spell.Price = price;

            // Assert
            Assert.AreEqual(2, spell.Price);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod()]
        public void PriceExceptionTest()
        {
            // Arrange
            var spell = new SpTest();
            int price = 5;
            // Act
            spell.Price = price;
        }
    }
}