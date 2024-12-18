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
        public void Test_Archer_Action_InteractionWithArcher()
        {
            // Arrange
            var archer1 = new Archer { Hp = 10, Damage = 3 };
            var archer2 = new Archer { Hp = 10, Damage = 2 };

            // Act
            archer2.Action(archer1);

            // Assert
            Assert.AreEqual(8, archer1.Hp); // У Archer должно остаться 8 HP
        }

        [TestMethod]
        public void Test_Archer_Action_InteractionWithFly()
        {
            // Arrange
            var archer = new Archer { Hp = 10, Damage = 3 };
            var fly = new Fly { Hp = 5, Damage = 1 };

            // Act
            fly.Action(archer);

            // Assert
            Assert.AreEqual(9, archer.Hp); // Archer теряет 1 HP
        }

        [TestMethod]
        public void Test_Archer_Action_InteractionWithMage()
        {
            // Arrange
            var archer = new Archer { Hp = 10, Damage = 3 };
            var mage = new Mage { Hp = 6, Damage = 4 };

            // Act
            mage.Action(archer);

            // Assert
            Assert.AreEqual(6, archer.Hp); // Archer теряет 4 HP
        }

        [TestMethod]
        public void Test_Archer_Action_InteractionWithMelee()
        {
            // Arrange
            var archer = new Archer { Hp = 10, Damage = 3 };
            var melee = new Melee { Hp = 8, Damage = 3 };

            // Act
            melee.Action(archer);

            // Assert
            Assert.AreEqual(5, archer.Hp); // Archer теряет (3 + 2) HP
        }

        [TestMethod]
        public void Test_Archer_Action_InteractionWithTank()
        {
            // Arrange
            var archer = new Archer { Hp = 10, Damage = 3 };
            var tank = new Tank { Hp = 8, Damage = 4 };

            // Act
            tank.Action(archer);

            // Assert
            Assert.AreEqual(6, archer.Hp); // Archer теряет 4 HP
        }
    }
}