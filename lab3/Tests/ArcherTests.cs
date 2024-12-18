using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobTest
{
    [TestClass()]
    public class ArcherTests
    {
        [TestMethod]
        public void Test_Archer_GetDamage_FromAnotherArcher()
        {
            // Arrange
            var archer = new Archer { Hp = 10, Damage = 3 };
            var enemyArcher = new Archer { Hp = 10, Damage = 2 };

            // Act
            archer.GetDamage(enemyArcher);

            // Assert
            Assert.AreEqual(8, archer.Hp); // У Archer должно остаться 8 HP
        }

        [TestMethod]
        public void Test_Archer_GetDamage_FromFly()
        {
            // Arrange
            var archer = new Archer { Hp = 10, Damage = 3 };
            var fly = new Fly { Hp = 5, Damage = 1 };

            // Act
            archer.GetDamage(fly);

            // Assert
            Assert.AreEqual(9, archer.Hp); // Archer теряет 1 HP
        }

        [TestMethod]
        public void Test_Archer_GetDamage_FromMage()
        {
            // Arrange
            var archer = new Archer { Hp = 10, Damage = 3 };
            var mage = new Mage { Hp = 6, Damage = 4 };

            // Act
            archer.GetDamage(mage);

            // Assert
            Assert.AreEqual(6, archer.Hp); // Archer теряет 4 HP
        }

        [TestMethod]
        public void Test_Archer_GetDamage_FromMelee()
        {
            // Arrange
            var archer = new Archer { Hp = 10, Damage = 3 };
            var melee = new Melee { Hp = 8, Damage = 3 };

            // Act
            archer.GetDamage(melee);

            // Assert
            Assert.AreEqual(5, archer.Hp); // Archer теряет (3 + 2) HP
        }

        [TestMethod]
        public void Test_Archer_GetDamage_FromTank()
        {
            // Arrange
            var archer = new Archer { Hp = 10, Damage = 3 };
            var tank = new Tank { Hp = 12, Damage = 4 };

            // Act
            archer.GetDamage(tank);

            // Assert
            Assert.AreEqual(6, archer.Hp); // Archer теряет 4 HP
        }
    }
}