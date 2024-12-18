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
    public class FlyTests
    {
        [TestMethod]
        public void Test_Fly_Action_InteractionWithArcher()
        {
            // Arrange
            var fly = new Fly { Hp = 10, Damage = 3 };
            var archer = new Archer { Hp = 8, Damage = 4 };

            // Act
            fly.Action(archer);

            // Assert
            Assert.AreEqual(5, archer.Hp); // У Archer должно остаться 5 HP после атаки Fly
        }

        [TestMethod]
        public void Test_Fly_Action_InteractionWithFly()
        {
            // Arrange
            var fly1 = new Fly { Hp = 10, Damage = 2 };
            var fly2 = new Fly { Hp = 6, Damage = 1 };

            // Act
            fly1.Action(fly2);

            // Assert
            Assert.AreEqual(4, fly2.Hp); // У второго Fly должно остаться 4 HP после атаки первого
        }

        [TestMethod]
        public void Test_Fly_Action_InteractionWithMage()
        {
            // Arrange
            var fly = new Fly { Hp = 10, Damage = 2 };
            var mage = new Mage { Hp = 8, Damage = 5 };

            // Act
            fly.Action(mage);

            // Assert
            Assert.AreEqual(6, mage.Hp); // У Mage должно остаться 6 HP после атаки Fly
        }

        [TestMethod]
        public void Test_Fly_Action_NoEffectOnMelee()
        {
            // Arrange
            var fly = new Fly { Hp = 10, Damage = 2 };
            var melee = new Melee { Hp = 10, Damage = 3 };

            // Act
            fly.Action(melee);

            // Assert
            Assert.AreEqual(10, melee.Hp); // У Melee HP не должно измениться, так как Fly не наносит урон Melee
        }

        [TestMethod]
        public void Test_Fly_Action_NoEffectOnTank()
        {
            // Arrange
            var fly = new Fly { Hp = 10, Damage = 2 };
            var tank = new Tank { Hp = 12, Damage = 4 };

            // Act
            fly.Action(tank);

            // Assert
            Assert.AreEqual(12, tank.Hp); // У Tank HP не должно измениться, так как Fly не наносит урон Tank
        }
    }
}