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
    public class TankTests
    {
        [TestMethod]
        public void Test_Tank_Action_InteractionWithArcher()
        {
            // Arrange
            var tank = new Tank { Hp = 10, Damage = 4 };
            var archer = new Archer { Hp = 3, Damage = 6 };

            // Act
            archer.Action(tank);

            // Assert
            Assert.AreEqual(6, tank.Hp); // Archer наносит урон Tank с уменьшением на 2, итоговый урон 6
        }

        [TestMethod]
        public void Test_Tank_Action_InteractionWithFly()
        {
            // Arrange
            var tank = new Tank { Hp = 10, Damage = 3 };
            var fly = new Fly { Hp = 10, Damage = 2 };

            // Act
            fly.Action(tank);

            // Assert
            Assert.AreEqual(8, tank.Hp); // Fly наносит Tank полный урон (2)
        }

        [TestMethod]
        public void Test_Tank_Action_InteractionWithMage()
        {
            // Arrange
            var tank = new Tank { Hp = 10, Damage = 4 };
            var mage = new Mage { Hp = 4, Damage = 7 };

            // Act
            mage.Action(tank);

            // Assert
            Assert.AreEqual(3, tank.Hp); // Mage наносит Tank полный урон (7)
        }

        [TestMethod]
        public void Test_Tank_Action_InteractionWithMelee()
        {
            // Arrange
            var tank = new Tank { Hp = 10, Damage = 6 };
            var melee = new Melee { Hp = 10, Damage = 8 };

            // Act
            melee.Action(tank);

            // Assert
            Assert.AreEqual(4, tank.Hp); // Melee наносит Tank урон с уменьшением на 2, итоговый урон 6
        }

        [TestMethod]
        public void Test_Tank_Action_InteractionWithTank()
        {
            // Arrange
            var tank1 = new Tank { Hp = 10, Damage = 5 };
            var tank2 = new Tank { Hp = 8, Damage = 4 };

            // Act
            tank1.Action(tank2);

            // Assert
            Assert.AreEqual(3, tank2.Hp); // Tank наносит другому Tank полный урон (5)
        }
    }
}