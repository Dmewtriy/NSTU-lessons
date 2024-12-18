using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerT
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void NameTest()
        {
            // Arrange
            Player player = new Player();
            Player player2 = new Player();
            string name = "Player2";
            // Act
            player2.Name = name;

            // Assert
            Assert.AreEqual(null, player.Name);
            Assert.AreEqual("Player2", player2.Name);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void NameNullExceptionTest()
        {
            // Arrange
            Player player = new Player();
            string name = null;

            // Act
            player.Name = name;
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void NameEmptyExceptionTest()
        {
            // Arrange
            Player player = new Player();

            // Act
            player.Name = " ";
        }

        [TestMethod()]
        public void CoinsTest()
        {
            // Arrange
            Player player = new Player();

            // Act
            player.Coins = 8;

            // Assert
            Assert.AreEqual(8, player.Coins);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void CoinException1Test()
        {
            // Arrange
            Player player = new Player();

            // Act
            player.Coins = -3;
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void CoinException2Test()
        {
            // Arrange
            Player player = new Player();

            // Act
            player.Coins = 13;

        }
        [TestMethod()]
        public void DeckTest()
        {
            // Arrange
            Player player = new Player();
            Deck deck = new Deck();
            Archer archer = new Archer { Hp = 10, Damage = 3 };
            deck.AddCard(archer);
        
            // Act
            player.Deck = deck;

            // Assert
            Assert.AreEqual(deck, player.Deck);
        }

        [TestMethod()]
        public void ActionTest()
        {
            // Arrange
            Archer archer = new Archer { Hp = 6, Damage = 3 };
            Tank enemy = new Tank { Hp = 10, Damage = 5 };

            Archer archer1 = new Archer { Hp = 5, Damage = 3 };
            Tank enemy1 = new Tank { Hp = 10, Damage = 5 };

            Player player = new Player();
            Player player1 = new Player();

            Deck deck = new Deck();
            Deck deck1 = new Deck();

            // Act
            deck.AddCard(archer);
            deck1.AddCard(enemy1);

            player.Deck = deck; 
            player1.Deck = deck1;

            // Assert
            Assert.AreEqual(true, player.Action(player.Deck.Cards[0], enemy));
            Assert.AreEqual(false, player1.Action(player1.Deck.Cards[0], archer1));
        }
    }
}