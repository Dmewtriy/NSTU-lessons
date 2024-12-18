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
            archer.Action(fly);

            // Assert
            Assert.AreEqual(6, fly.Hp); // У Archer должно остаться 5 HP после атаки Fly
        }

        [TestMethod]
        public void Test_Fly_Action_InteractionWithFly()
        {
            // Arrange
            var fly1 = new Fly { Hp = 10, Damage = 2 };
            var fly2 = new Fly { Hp = 6, Damage = 1 };

            // Act
            fly2.Action(fly1);

            // Assert
            Assert.AreEqual(9, fly1.Hp); // У второго Fly должно остаться 4 HP после атаки первого
        }

        [TestMethod]
        public void Test_Fly_Action_InteractionWithMage()
        {
            // Arrange
            var fly = new Fly { Hp = 10, Damage = 2 };
            var mage = new Mage { Hp = 8, Damage = 5 };

            // Act
            mage.Action(fly);

            // Assert
            Assert.AreEqual(5, fly.Hp); // У Mage должно остаться 6 HP после атаки Fly
        }

        [TestMethod]
        public void Test_Fly_Action_NoEffectOnMelee()
        {
            // Arrange
            var fly = new Fly { Hp = 10, Damage = 2 };
            var melee = new Melee { Hp = 5, Damage = 3 };

            // Act
            melee.Action(fly);

            // Assert
            Assert.AreEqual(10, fly.Hp); 
        }

        [TestMethod]
        public void Test_Fly_Action_NoEffectOnTank()
        {
            // Arrange
            var fly = new Fly { Hp = 10, Damage = 2 };
            var tank = new Tank { Hp = 5, Damage = 4 };

            // Act
            tank.Action(fly);

            // Assert
            Assert.AreEqual(10, fly.Hp); // У Tank HP не должно измениться, так как Fly не наносит урон Tank
        }
    }
}