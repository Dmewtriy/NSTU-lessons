using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class PlayForm : Form
    {
        private Game game;
        private List<Card> allCards; // Список всех доступных карт
        private Random random;

        public PlayForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeComponent()
        {
            this.listBoxMyCards = new System.Windows.Forms.ListBox();
            this.listBoxOpponentCards = new System.Windows.Forms.ListBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayerCoins = new System.Windows.Forms.Label();
            this.lblOpponentCoins = new System.Windows.Forms.Label();
            this.NamePlayer1 = new System.Windows.Forms.Label();
            this.NamePlayer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxMyCards
            // 
            this.listBoxMyCards.FormattingEnabled = true;
            this.listBoxMyCards.Location = new System.Drawing.Point(12, 50);
            this.listBoxMyCards.Name = "listBoxMyCards";
            this.listBoxMyCards.Size = new System.Drawing.Size(194, 186);
            this.listBoxMyCards.TabIndex = 0;
            // 
            // listBoxOpponentCards
            // 
            this.listBoxOpponentCards.FormattingEnabled = true;
            this.listBoxOpponentCards.Location = new System.Drawing.Point(340, 50);
            this.listBoxOpponentCards.Name = "listBoxOpponentCards";
            this.listBoxOpponentCards.Size = new System.Drawing.Size(201, 186);
            this.listBoxOpponentCards.TabIndex = 1;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(575, 220);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(172, 50);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Атаковать";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(575, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlayerCoins
            // 
            this.lblPlayerCoins.AutoSize = true;
            this.lblPlayerCoins.Location = new System.Drawing.Point(12, 31);
            this.lblPlayerCoins.Name = "lblPlayerCoins";
            this.lblPlayerCoins.Size = new System.Drawing.Size(45, 13);
            this.lblPlayerCoins.TabIndex = 4;
            this.lblPlayerCoins.Text = "Coins: 0";
            // 
            // lblOpponentCoins
            // 
            this.lblOpponentCoins.AutoSize = true;
            this.lblOpponentCoins.Location = new System.Drawing.Point(337, 31);
            this.lblOpponentCoins.Name = "lblOpponentCoins";
            this.lblOpponentCoins.Size = new System.Drawing.Size(45, 13);
            this.lblOpponentCoins.TabIndex = 5;
            this.lblOpponentCoins.Text = "Coins: 0";
            // 
            // NamePlayer1
            // 
            this.NamePlayer1.AutoSize = true;
            this.NamePlayer1.Location = new System.Drawing.Point(12, 12);
            this.NamePlayer1.Name = "NamePlayer1";
            this.NamePlayer1.Size = new System.Drawing.Size(42, 13);
            this.NamePlayer1.TabIndex = 6;
            this.NamePlayer1.Text = "Player1";
            this.NamePlayer1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NamePlayer2
            // 
            this.NamePlayer2.AutoSize = true;
            this.NamePlayer2.Location = new System.Drawing.Point(337, 11);
            this.NamePlayer2.Name = "NamePlayer2";
            this.NamePlayer2.Size = new System.Drawing.Size(42, 13);
            this.NamePlayer2.TabIndex = 7;
            this.NamePlayer2.Text = "Player2";
            // 
            // PlayForm
            // 
            this.ClientSize = new System.Drawing.Size(776, 276);
            this.Controls.Add(this.NamePlayer2);
            this.Controls.Add(this.NamePlayer1);
            this.Controls.Add(this.lblOpponentCoins);
            this.Controls.Add(this.lblPlayerCoins);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.listBoxOpponentCards);
            this.Controls.Add(this.listBoxMyCards);
            this.Name = "PlayForm";
            this.Text = "Игра";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeGame()
        {
            // Загрузка состояния игры
            allCards = new AllCards().Cards;
            random = new Random();
            LoadGameState();
            UpdateGameUI();
            isPlayer1Turn = new Random().Next(2) == 0; // Случайный выбор, кто начинает
        }

        private void UpdateGameUI()
        {
            // Обновление интерфейса
            listBoxMyCards.DataSource = null;
            listBoxMyCards.DataSource = game.Player1.Deck.Cards.Where(c => c is Mob).ToList(); // Только мобы
            listBoxOpponentCards.DataSource = null;
            listBoxOpponentCards.DataSource = game.Player2.Deck.Cards.Where(c => c is Mob).ToList(); // Только мобы
            lblPlayerCoins.Text = $"Coins: {game.Player1.Coins}";
            lblOpponentCoins.Text = $"Coins: {game.Player2.Coins}";
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (isPlayer1Turn)
            {
                game.CurrentStatus = new PlayerAction();
                // Игрок 1 атакует
                if (listBoxMyCards.SelectedItem != null)
                {
                    var selectedMyCard = (Mob)listBoxMyCards.SelectedItem;
                    var selectedOpponentCard = (Mob)listBoxOpponentCards.SelectedItem;
                    game.PerformAction(selectedMyCard, selectedOpponentCard);
                    UpdateGameUI();
                }
            }
            else
            {
                game.CurrentStatus = new WaitingForOpponentAction();
                // Игрок 2 атакует (бот)
                if (listBoxOpponentCards.Items.Count > 0)
                {
                    var index = random.Next(listBoxMyCards.Items.Count);
                    var card = (Card)listBoxOpponentCards.Items[index];
                    game.PerformAction(card, listBoxMyCards.Items[index] as Mob);
                    UpdateGameUI();
                }
            }

            isPlayer1Turn = !isPlayer1Turn;
        }

        private void Attack(Mob myCard, Mob opponentCard)
        {
            // Использование метода атаки из класса Card
            myCard.Action(opponentCard);
            if (opponentCard.Hp <= 0)
            {
                game.Player2.Deck.Cards.Remove(opponentCard);
            }
        }

        private void SwitchTurn()
        {
            isPlayer1Turn = !isPlayer1Turn;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //SaveGameState();
            this.Close();
        }

        private void LoadGameState()
        {
            // Загрузка состояния игры из файла
            if (File.Exists("gameState.json") && false)
            {
                var json = File.ReadAllText("gameState.json");
                game = JsonConvert.DeserializeObject<Game>(json);
            }
            else
            {
                // Инициализация новых игроков и колод
                Deck deck1 = GenerateRandomDeck();
                Deck deck2 = GenerateRandomDeck();
                Settings stg = new Settings();
                game = new Game(new Player(deck1), new Player(deck2), stg);
            }
        }

        /*private void SaveGameState()
        {
            // Сохранение состояния игры в файл
            var json = JsonConvert.SerializeObject(game);
            File.WriteAllText("gameState.json", json);
        }*/

        private Deck GenerateRandomDeck()
        {
            // Генерация случайной колоды из списка всех карт
            var deck = new Deck();
            var random = new Random();
            for (int i = 0; i < 10; i++) // Пример: добавляем 10 случайных карт
            {
                Card randomCard = allCards[random.Next(allCards.Count)]; // Случайная карта из списка
                deck.Cards.Add(randomCard.Clone() as Card);
            }
            return deck;
        }

        private System.Windows.Forms.ListBox listBoxMyCards;
        private System.Windows.Forms.ListBox listBoxOpponentCards;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayerCoins;
        private System.Windows.Forms.Label lblOpponentCoins;

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

