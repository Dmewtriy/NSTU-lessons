using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellLevel2Test
{
    [TestClass()]
    public class AllSpellTests
    {
        [TestMethod()]
        public void ActionHealthTest()
        {
            // Arrange
            var archer = new Archer { Hp = 6, Damage = 3 };
            var heal = new HealthSpell { Effect = 3 };
            // Act
            heal.Action(archer);

            // Assert
            Assert.AreEqual(9, archer.Hp); 
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod()]
        public void ActionHealthExceptionTest()
        {
            // Arrange
            var archer = new Archer { Hp = 8, Damage = 3 };
            var heal = new HealthSpell { Effect = 3 };
            // Act
            heal.Action(archer);

        }

        [TestMethod()]
        public void ActionUpgradeAttackTest()
        {
            // Arrange
            var archer = new Archer { Hp = 6, Damage = 3 };
            var upAttack = new UpgradeAttackSpell { Effect = 3 };
            // Act
            upAttack.Action(archer);

            // Assert
            Assert.AreEqual(6, archer.Damage); 
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod()]
        public void ActionUpgradeAttackExceptionTest()
        {
            // Arrange
            var archer = new Archer { Hp = 6, Damage = 8 };
            var upAttack = new UpgradeAttackSpell { Effect = 3 };
            // Act
            upAttack.Action(archer);

        }

        [TestMethod()]
        public void ActionLowAttackTest()
        {
            // Arrange
            var archer1 = new Archer { Hp = 6, Damage = 4 };
            var lowAttack1 = new LowAttackSpell { Effect = 2 };

            var archer2 = new Archer { Hp = 6, Damage = 2 };
            var lowAttack2 = new LowAttackSpell{ Effect = 3 };

            // Act
            lowAttack1.Action(archer1);
            lowAttack2.Action(archer2);


            // Assert
            Assert.AreEqual(2, archer1.Damage);
            Assert.AreEqual(1, archer2.Damage);

        }
    }
}