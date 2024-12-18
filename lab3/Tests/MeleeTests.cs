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
            var melee = new Melee { Hp = 20, Damage = 4 };
            var archer = new Archer { Hp = 15, Damage = 6 };

            // Act
            archer.Action(melee);

            // Assert
            Assert.AreEqual(14, melee.Hp);
        }

        [TestMethod]
        public void Test_Melee_Action_InteractionWithFly()
        {
            // Arrange
            var melee = new Melee { Hp = 20, Damage = 3 };
            var fly = new Fly { Hp = 10, Damage = 2 };

            // Act
            fly.Action(melee);

            // Assert
            Assert.AreEqual(18, melee.Hp); 
        }

        [TestMethod]
        public void Test_Melee_Action_InteractionWithMage()
        {
            // Arrange
            var melee = new Melee { Hp = 25, Damage = 4 };
            var mage = new Mage { Hp = 12, Damage = 7 };

            // Act
            mage.Action(melee);

            // Assert
            Assert.AreEqual(18, melee.Hp);
        }

        [TestMethod]
        public void Test_Melee_Action_InteractionWithTank()
        {
            // Arrange
            var melee = new Melee { Hp = 30, Damage = 6 };
            var tank = new Tank { Hp = 10, Damage = 8 };

            // Act
            tank.Action(melee);

            // Assert
            Assert.AreEqual(22, melee.Hp); 
        }

        [TestMethod]
        public void Test_Melee_Action_InteractionWithMelee()
        {
            // Arrange
            var melee1 = new Melee { Hp = 25, Damage = 5 };
            var melee2 = new Melee { Hp = 20, Damage = 4 };

            // Act
            melee1.Action(melee2);

            // Assert
            Assert.AreEqual(15, melee2.Hp); 
        }
    }
}