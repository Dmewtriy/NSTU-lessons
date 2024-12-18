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
        private ListBox player1Cards;
        private ListBox player2Cards;
        private Label lblPlayer1Name;
        private Label lblPlayer2Name;
        private TextBox status;
        private Button btnAttack;
        private Button btnExit;
        private Label lblPlayer1Coins;
        private Label lblPlayer2Coins;
        private Button skipMove;

        public PlayForm(Game game)
        {
            InitializeComponent(game);
            UpdateGameUI(game);
        }

        private void InitializeComponent(Game game)
        {
            this.player1Cards = new ListBox();
            this.player2Cards = new ListBox();
            lblPlayer1Name = new Label() { Text = game.Player1.Name };
            lblPlayer2Name = new Label() { Text = game.Player2.Name };
            this.btnAttack = new Button();
            this.btnExit = new Button();
            this.lblPlayer1Coins = new Label();
            this.lblPlayer2Coins = new Label();
            this.lblPlayer1Name = new Label();
            this.lblPlayer2Name = new Label();
            status = new TextBox() { ReadOnly = true, Location = new Point(380, 100), Size = new Size(121, 80) };
            skipMove = new Button();
            this.SuspendLayout();
            // 
            // player1Cards
            // 
            this.player1Cards.FormattingEnabled = true;
            this.player1Cards.Location = new System.Drawing.Point(12, 50);
            this.player1Cards.Name = "player1Cards";
            this.player1Cards.Size = new System.Drawing.Size(370, 150);
            this.player1Cards.TabIndex = 0;
            // 
            // player2Cards
            // 
            this.player2Cards.FormattingEnabled = true;
            this.player2Cards.Location = new System.Drawing.Point(500, 50);
            this.player2Cards.Name = "player2Cards";
            this.player2Cards.Size = new System.Drawing.Size(370, 150);
            this.player2Cards.TabIndex = 1;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(350, 200);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(172, 50);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Атаковать";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += (sender, e) => btnAttack_Click(game);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(630, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Сохранить и выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += (sender, e) => btnExit_Click(game);
            // 
            // lblPlayer1Coins
            // 
            this.lblPlayer1Coins.AutoSize = true;
            this.lblPlayer1Coins.Location = new System.Drawing.Point(12, 30);
            this.lblPlayer1Coins.Name = "lblPlayer1Coins";
            this.lblPlayer1Coins.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer1Coins.TabIndex = 4;
            this.lblPlayer1Coins.Text = $"Coins: {game.Player1.Coins}";
            // 
            // lblPlayer2Coins
            // 
            this.lblPlayer2Coins.AutoSize = true;
            this.lblPlayer2Coins.Location = new System.Drawing.Point(500, 30);
            this.lblPlayer2Coins.Name = "lblPlayer2Coins";
            this.lblPlayer2Coins.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer2Coins.TabIndex = 5;
            this.lblPlayer2Coins.Text = $"Coins: {game.Player2.Coins}";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(12, 10);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer1Name.TabIndex = 6;
            this.lblPlayer1Name.Text = game.Player1.Name;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(500, 10);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer2Name.TabIndex = 7;
            this.lblPlayer2Name.Text = game.Player2.Name;
            // 
            // skipMove
            // 
            this.skipMove.Location = new System.Drawing.Point(350, 280);
            this.skipMove.Name = "skipMove";
            this.skipMove.Size = new System.Drawing.Size(172, 50);
            this.skipMove.TabIndex = 2;
            this.skipMove.Text = "Пропустить ход";
            this.skipMove.UseVisualStyleBackColor = true;
            this.skipMove.Click += (sender, e) => skipMove_Click(game);
            // 
            // PlayForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer2Coins);
            this.Controls.Add(this.lblPlayer1Coins);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.player2Cards);
            this.Controls.Add(this.player1Cards);
            this.Controls.Add(skipMove);
            Controls.Add(status);
            this.Name = "PlayForm";
            this.Text = "Игра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UpdateGameUI(Game game)
        {
            // Обновление интерфейса
            player1Cards.DataSource = null;
            player1Cards.DataSource = game.Player1.Deck.Cards;
            player2Cards.DataSource = null;
            player2Cards.DataSource = game.Player2.Deck.Cards;
            lblPlayer1Coins.Text = $"Coins: {game.Player1.Coins}";
            lblPlayer2Coins.Text = $"Coins: {game.Player2.Coins}";
            if (game.Player1.IsPlayerTurn)
            {
                status.Text = $"Ход игрока {game.Player1.Name}";
            }
            else
            {
                status.Text = $"Ход игрока {game.Player2.Name}";
            }
        }

        private void btnAttack_Click(Game game)
        {
            if (game.Player1.IsPlayerTurn)
            {
                if (player1Cards.SelectedItem != null && player2Cards.SelectedItem != null)
                {
                    var selectedCard1 = (Card)player1Cards.SelectedItem;
                    var selectedCard2 = player2Cards.SelectedItem;
                    if (selectedCard2 is Mob card2Mob)
                    {
                        try
                        {
                            if (!game.Player1.Action(selectedCard1, card2Mob))
                            {
                                game.Player2.Deck.Cards.Remove(selectedCard2 as Card);
                            }
                            SwitchTurn(game);
                            game.Player2.addCoinsPerRound(3);
                            UpdateGameUI(game);
                            if (game.gameIsEnd(game.Player2))
                            {
                                MessageBox.Show($"Победил игрок {game.Player1.Name}", "Победа", MessageBoxButtons.OK);
                                Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show(this, "Недостаточно монет для атаки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Можно атаковать только мобов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var selectedCard1 = (Card)player2Cards.SelectedItem;
                var selectedCard2 = player1Cards.SelectedItem;
                if (selectedCard2 is Mob card2Mob)
                {
                    try
                    {
                        if (!game.Player2.Action(selectedCard1, card2Mob))
                        {
                            game.Player1.Deck.Cards.Remove(selectedCard2 as Card);
                        }
                        SwitchTurn(game);
                        game.Player1.addCoinsPerRound(3);
                        UpdateGameUI(game);
                        if (game.gameIsEnd(game.Player1))
                        {
                            MessageBox.Show($"Победил игрок {game.Player2.Name}", "Победа", MessageBoxButtons.OK);
                            Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show(this, "Недостаточно монет для атаки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Можно атаковать только мобов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void SwitchTurn(Game game)
        {
            game.SwitchTurn();
        }

        private void btnExit_Click(Game game)
        {
            game.SaveGame();
            Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void skipMove_Click(Game game)
        {
            if (game.Player1.IsPlayerTurn)
            {
                SwitchTurn(game);
                game.Player2.addCoinsPerRound(3);
            }
            else
            {
                SwitchTurn(game);
                game.Player1.addCoinsPerRound(3);
            }
            UpdateGameUI(game);
        }
    }
}

