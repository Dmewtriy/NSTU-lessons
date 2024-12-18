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

        private Button btnAddCardPlayer1Player1;
        private Button btnAddCardPlayer1Player2;
        private Button btnRemoveCardPlayer1Player1;
        private Button btnRemoveCardPlayer1Player2;
        public CreateGameForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            allCards = new ListBox();
            player1Cards = new ListBox();
            player2Cards = new ListBox();
            lblPlayer1Name = new Label() { Text = "Имя игрока 1" };
            lblPlayer2Name = new Label() { Text = "Имя игрока 2" };
            btnAddCardPlayer1Player1 = new Button();
            btnRemoveCardPlayer1Player1 = new Button();
            btnAddCardPlayer1Player2 = new Button();
            btnRemoveCardPlayer1Player2 = new Button();

            SuspendLayout();
            //
            // allCards
            //
            allCards.FormattingEnabled = true;
            allCards.Location = new System.Drawing.Point(12, 12);
            allCards.Name = "allCards";
            allCards.Size = new System.Drawing.Size(200, 150);
            allCards.TabIndex = 0;
            // 
            // player1Cards
            // 
            player1Cards.FormattingEnabled = true;
            player1Cards.Location = new System.Drawing.Point(12, 12);
            player1Cards.Name = "player1Cards";
            player1Cards.Size = new System.Drawing.Size(200, 150);
            player1Cards.TabIndex = 0;
            // 
            // player2Cards
            // 
            player2Cards.FormattingEnabled = true;
            player2Cards.Location = new System.Drawing.Point(250, 12);
            player2Cards.Name = "player2Cards";
            player2Cards.Size = new System.Drawing.Size(200, 150);
            player2Cards.TabIndex = 1;
            // 
            // btnAddCardPlayer1
            // 
            this.btnAddCardPlayer1.Location = new System.Drawing.Point(220, 50);
            this.btnAddCardPlayer1.Name = "btnAddCardPlayer1";
            this.btnAddCardPlayer1.Size = new System.Drawing.Size(20, 50);
            this.btnAddCardPlayer1.TabIndex = 2;
            this.btnAddCardPlayer1.Text = "→";
            this.btnAddCardPlayer1.UseVisualStyleBackColor = true;
            this.btnAddCardPlayer1.Click += new System.EventHandler(this.btnAddCardPlayer1_Click);
            // 
            // btnRemoveCardPlayer1
            // 
            this.btnRemoveCardPlayer1.Location = new System.Drawing.Point(220, 120);
            this.btnRemoveCardPlayer1.Name = "btnRemoveCardPlayer1";
            this.btnRemoveCardPlayer1.Size = new System.Drawing.Size(20, 50);
            this.btnRemoveCardPlayer1.TabIndex = 3;
            this.btnRemoveCardPlayer1.Text = "←";
            this.btnRemoveCardPlayer1.UseVisualStyleBackColor = true;
            this.btnRemoveCardPlayer1.Click += new System.EventHandler(this.btnRemoveCardPlayer1_Click);
            // 
            // btnAddCardPlayer2
            // 
            this.btnAddCardPlayer2.Location = new System.Drawing.Point(220, 50);
            this.btnAddCardPlayer2.Name = "btnAddCardPlayer2";
            this.btnAddCardPlayer2.Size = new System.Drawing.Size(20, 50);
            this.btnAddCardPlayer2.TabIndex = 2;
            this.btnAddCardPlayer2.Text = "→";
            this.btnAddCardPlayer2.UseVisualStyleBackColor = true;
            this.btnAddCardPlayer2.Click += new System.EventHandler(this.btnAddCardPlayer2_Click);
            // 
            // btnRemoveCardPlayer2
            // 
            this.btnRemoveCardPlayer2.Location = new System.Drawing.Point(220, 120);
            this.btnRemoveCardPlayer2.Name = "btnRemoveCardPlayer2";
            this.btnRemoveCardPlayer2.Size = new System.Drawing.Size(20, 50);
            this.btnRemoveCardPlayer2.TabIndex = 3;
            this.btnRemoveCardPlayer2.Text = "←";
            this.btnRemoveCardPlayer2.UseVisualStyleBackColor = true;
            this.btnRemoveCardPlayer2.Click += new System.EventHandler(this.btnRemoveCardPlayer2_Click);

            ClientSize = new System.Drawing.Size(400, 250);
            Controls.Add(allCards);
            Controls.Add(player1Cards);
            Controls.Add(player2Cards);
            Controls.Add(lblPlayer1Name);
            Controls.Add(lblPlayer2Name);
            Controls.Add(btnAddCardPlayer1Player1);
            Controls.Add(btnRemoveCardPlayer1Player1);
            Controls.Add(btnAddCardPlayer1Player2);
            Controls.Add(btnRemoveCardPlayer1Player2);
            Name = "MainForm";
            Text = "Главное меню";
            ResumeLayout(false);
        }

        private void btnAddCardPlayer1_Click(object sender, EventArgs e)
        {
            if (player1Cards.Items.Count < Deck.MaxDeckSize)
            {
                Card selectedCard = (Card)allCards.SelectedItem;
                if (selectedCard != null && !player1Cards.Contains(selectedCard))
                {
                    myCards.Add(selectedCard);
                    UpdateCardLists();
                }
                else
                {
                    MessageBox.Show("Выберите карту из общего списка или карта уже в колоде.");
                }
            }
            else
            {
                MessageBox.Show("Достигнуто максимальное количество карт в колоде.");
            }
        }
    }
}
