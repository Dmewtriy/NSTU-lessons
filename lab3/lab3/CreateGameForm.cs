using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class CreateGameForm : Form
    {
        private Label lblPlayer1Name;
        private TextBox txtPlayer1Name;
        private Label lblPlayer2Name;
        private TextBox txtPlayer2Name;

        private ListBox player1Cards;
        private ListBox player2Cards;
        private ListBox allCards;

        private Button btnAddCardPlayer1;
        private Button btnAddCardPlayer2;
        private Button btnRemoveCardPlayer1;
        private Button btnRemoveCardPlayer2;

        private Button save;
        public CreateGameForm(Game game)
        {
            InitializeComponent(game);
            UpdateCardLists(game);
        }
        private void InitializeComponent(Game game)
        {
            allCards = new ListBox();
            player1Cards = new ListBox();
            player2Cards = new ListBox();
            lblPlayer1Name = new Label() { Text = "Имя игрока 1", Location = new Point(12, 5), BorderStyle = BorderStyle.FixedSingle};
            txtPlayer1Name = new TextBox() { Location = new Point(120, 5) , Text = "Player 1"};
            lblPlayer2Name = new Label() { Text = "Имя игрока 2", Location = new Point(400, 5), BorderStyle = BorderStyle.FixedSingle };
            txtPlayer2Name = new TextBox() { Location = new Point(508, 5) , Text = "Player 2" };
            btnAddCardPlayer1 = new Button();
            btnRemoveCardPlayer1 = new Button();
            btnAddCardPlayer2 = new Button();
            btnRemoveCardPlayer2 = new Button();
            save = new Button() { Text = "Сохранить", Location = new Point(350, 450) };

            SuspendLayout();
            //
            // allCards
            //
            allCards.FormattingEnabled = true;
            allCards.Location = new System.Drawing.Point(194, 250);
            allCards.Name = "allCards";
            allCards.Size = new System.Drawing.Size(370, 150);
            allCards.TabIndex = 0;
            // 
            // player1Cards
            // 
            player1Cards.FormattingEnabled = true;
            player1Cards.Location = new System.Drawing.Point(12, 30);
            player1Cards.Name = "player1Cards";
            player1Cards.Size = new System.Drawing.Size(370, 150);
            player1Cards.TabIndex = 0;
            // 
            // player2Cards
            // 
            player2Cards.FormattingEnabled = true;
            player2Cards.Location = new System.Drawing.Point(400, 30);
            player2Cards.Name = "player2Cards";
            player2Cards.Size = new System.Drawing.Size(370, 150);
            player2Cards.TabIndex = 1;
            // 
            // btnAddCardPlayer1
            // 
            this.btnAddCardPlayer1.Location = new System.Drawing.Point(12, 180);
            this.btnAddCardPlayer1.Name = "btnAddCardPlayer1";
            this.btnAddCardPlayer1.Size = new System.Drawing.Size(50, 50);
            this.btnAddCardPlayer1.TabIndex = 2;
            this.btnAddCardPlayer1.Text = "+pl1";
            this.btnAddCardPlayer1.UseVisualStyleBackColor = true;
            this.btnAddCardPlayer1.Click += (sender, e) => btnAddCardPlayer1_Click(game);
            // 
            // btnRemoveCardPlayer1
            // 
            this.btnRemoveCardPlayer1.Location = new System.Drawing.Point(82, 180);
            this.btnRemoveCardPlayer1.Name = "btnRemoveCardPlayer1";
            this.btnRemoveCardPlayer1.Size = new System.Drawing.Size(50, 50);
            this.btnRemoveCardPlayer1.TabIndex = 3;
            this.btnRemoveCardPlayer1.Text = "-pl1";
            this.btnRemoveCardPlayer1.UseVisualStyleBackColor = true;
            this.btnRemoveCardPlayer1.Click += (sender, e) => btnRemoveCardPlayer1_Click(game);
            // 
            // btnAddCardPlayer2
            // 
            this.btnAddCardPlayer2.Location = new System.Drawing.Point(400, 180);
            this.btnAddCardPlayer2.Name = "btnAddCardPlayer2";
            this.btnAddCardPlayer2.Size = new System.Drawing.Size(50, 50);
            this.btnAddCardPlayer2.TabIndex = 2;
            this.btnAddCardPlayer2.Text = "+pl2";
            this.btnAddCardPlayer2.UseVisualStyleBackColor = true;
            this.btnAddCardPlayer2.Click += (sender, e) => btnAddCardPlayer2_Click(game);
            // 
            // btnRemoveCardPlayer2
            // 
            this.btnRemoveCardPlayer2.Location = new System.Drawing.Point(480, 180);
            this.btnRemoveCardPlayer2.Name = "btnRemoveCardPlayer2";
            this.btnRemoveCardPlayer2.Size = new System.Drawing.Size(50, 50);
            this.btnRemoveCardPlayer2.TabIndex = 3;
            this.btnRemoveCardPlayer2.Text = "-pl2";
            this.btnRemoveCardPlayer2.UseVisualStyleBackColor = true;
            this.btnRemoveCardPlayer2.Click += (sender, e) => btnRemoveCardPlayer2_Click(game);

            save.Click += (sender, e) => SaveGame(game);

            ClientSize = new Size(800, 500);
            Controls.Add(allCards);
            Controls.Add(player1Cards);
            Controls.Add(player2Cards);
            Controls.Add(lblPlayer1Name);
            Controls.Add(txtPlayer1Name);
            Controls.Add(lblPlayer2Name);
            Controls.Add(txtPlayer2Name);
            Controls.Add(btnAddCardPlayer1);
            Controls.Add(btnRemoveCardPlayer1);
            Controls.Add(btnAddCardPlayer2);
            Controls.Add(btnRemoveCardPlayer2);
            Controls.Add(save);
            Name = "MainForm";
            Text = "Главное меню";
            ResumeLayout(false);
            FormClosed += (sender, e) => SaveGame(game);
        }

        private void btnAddCardPlayer1_Click(Game game)
        {
            try
            {
                game.Player1.Deck.AddCard((Card)allCards.SelectedItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateCardLists(game);
            }
        }
        private void btnAddCardPlayer2_Click(Game game)
        {
            try
            {
                game.Player2.Deck.AddCard((Card)allCards.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
            finally
            {
                UpdateCardLists(game);
            }
        }
        private void btnRemoveCardPlayer1_Click(Game game)
        {
            game.Player1.Deck.RemoveCard((Card)player1Cards.SelectedItem);
            UpdateCardLists(game);
        }
        private void btnRemoveCardPlayer2_Click(Game game)
        {
            game.Player2.Deck.RemoveCard((Card)player2Cards.SelectedItem);
            UpdateCardLists(game);
        }

        private Game SaveGame(Game game)
        {
            try
            {
                game.Player1.Name = txtPlayer1Name.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message);
                game.Player1.Name = "Player 1";
            }
            try
            {
                game.Player2.Name = txtPlayer2Name.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                game.Player2.Name = "Player 2";
            }
            game.Player1.Coins = 12;
            game.Player2.Coins = 12;
            game.SaveGame();
            return game;
        }

        private void UpdateCardLists(Game game)
        {
            player1Cards.DataSource = null;
            player1Cards.DataSource = game.Player1.Deck.Cards;
            player2Cards.DataSource = null;
            player2Cards.DataSource = game.Player2.Deck.Cards;
            allCards.DataSource = null;
            allCards.DataSource = game.allCards.Cards;
        }
    }
}
