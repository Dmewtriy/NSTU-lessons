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
    public class MageTests
    {
        [TestMethod]
        public void Test_Mage_Action_InteractionWithArcher()
        {
            // Arrange
            var mage = new Mage { Hp = 20, Damage = 4 };
            var archer = new Archer { Hp = 15, Damage = 6 };

            // Act
            archer.Action(mage);

            // Assert
            Assert.AreEqual(12, mage.Hp);
        }

        [TestMethod]
        public void Test_Mage_Action_InteractionWithFly()
        {
            // Arrange
            var mage = new Melee { Hp = 20, Damage = 3 };
            var fly = new Fly { Hp = 10, Damage = 2 };

            // Act
            fly.Action(mage);

            // Assert
            Assert.AreEqual(18, mage.Hp);
        }

        [TestMethod]
        public void Test_Mage_Action_InteractionWithMelee()
        {
            // Arrange
            var melee = new Melee { Hp = 25, Damage = 4 };
            var mage = new Mage { Hp = 12, Damage = 7 };

            // Act
            melee.Action(mage);

            // Assert
            Assert.AreEqual(18, mage.Hp);
        }

        [TestMethod]
        public void Test_Mage_Action_InteractionWithTank()
        {
            // Arrange
            var mage = new Mage { Hp = 30, Damage = 6 };
            var tank = new Tank { Hp = 10, Damage = 8 };

            // Act
            tank.Action(mage);

            // Assert
            Assert.AreEqual(22, mage.Hp);
        }

        [TestMethod]
        public void Test_Mage_Action_InteractionWithMage()
        {
            // Arrange
            var mage1 = new Mage { Hp = 25, Damage = 5 };
            var mage2 = new Mage { Hp = 20, Damage = 4 };

            // Act
            mage1.Action(mage2);

            // Assert
            Assert.AreEqual(15, mage2.Hp);
        }
    }
}