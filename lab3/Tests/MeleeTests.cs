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
    public class MeleeTests
    {
        [TestMethod]
        public void Test_Melee_Action_InteractionWithArcher()
        {
            // Arrange
            var melee = new Melee { Hp = 10, Damage = 4 };
            var archer = new Archer { Hp = 7, Damage = 6 };

            // Act
            archer.Action(melee);

            // Assert
            Assert.AreEqual(4, melee.Hp);
        }

        [TestMethod]
        public void Test_Melee_Action_InteractionWithFly()
        {
            // Arrange
            var melee = new Melee { Hp = 10, Damage = 3 };
            var fly = new Fly { Hp = 5, Damage = 2 };

            // Act
            fly.Action(melee);

            // Assert
            Assert.AreEqual(8, melee.Hp); 
        }

        [TestMethod]
        public void Test_Melee_Action_InteractionWithMage()
        {
            // Arrange
            var melee = new Melee { Hp = 10, Damage = 4 };
            var mage = new Mage { Hp = 3, Damage = 7 };

            // Act
            mage.Action(melee);

            // Assert
            Assert.AreEqual(3, melee.Hp);
        }

        [TestMethod]
        public void Test_Melee_Action_InteractionWithTank()
        {
            // Arrange
            var melee = new Melee { Hp = 10, Damage = 6 };
            var tank = new Tank { Hp = 10, Damage = 8 };

            // Act
            tank.Action(melee);

            // Assert
            Assert.AreEqual(2, melee.Hp); 
        }

        [TestMethod]
        public void Test_Melee_Action_InteractionWithMelee()
        {
            // Arrange
            var melee1 = new Melee { Hp = 10, Damage = 5 };
            var melee2 = new Melee { Hp = 8, Damage = 4 };

            // Act
            melee1.Action(melee2);

            // Assert
            Assert.AreEqual(3, melee2.Hp); 
        }
    }
}