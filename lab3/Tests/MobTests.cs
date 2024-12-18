using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Tests
{
    [TestClass]
    public class MobTests
    {
        // Временный класс для тестирования абстрактного класса Mob
        public class TestMob : Mob, Interfaces.IGetDamage
        {
            public override void Action(Mob enemy)
            {
               
            }
            public override void GetDamage(Archer archer)
            {
                Hp -= archer.Damage;
            }

            public override void GetDamage(Fly fly)
            {
                Hp -= fly.Damage;
            }

            public override void GetDamage(Mage mage)
            {
                Hp -= mage.Damage;
            }

            public override void GetDamage(Melee melee)
            {
                Hp -= melee.Damage;
            }

            public override void GetDamage(Tank tank)
            {
                Hp -= tank.Damage;
            }
            
        }

        [TestMethod]
        public void Test_ValidHpAndDamage()
        {
            // Arrange
            var mob = new TestMob();

            // Act
            mob.Hp = 10;
            mob.Damage = 5;

            // Assert
            Assert.AreEqual(10, mob.Hp, "Hp должно быть равно 10.");
            Assert.AreEqual(5, mob.Damage, "Damage должно быть равно 5.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_InvalidHp_ThrowsException()
        {
            // Arrange
            var mob = new TestMob();

            // Act
            mob.Hp = 11; // Неверное значение здоровья, должно вызвать исключение
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_InvalidDamage_ThrowsException()
        {
            // Arrange
            var mob = new TestMob();

            // Act
            mob.Damage = 9; // Неверное значение урона, должно вызвать исключение
        }
    }
}