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
    public partial class DeckForm : Form
    {
        private List<Card> myCards; // Список наших карт
        private List<Card> allCards; // Список общих карт
        private const int MaxCards = 10; // Максимальное количество карт в колоде

        public DeckForm()
        {
            InitializeComponent();
            myCards = new List<Card>();
            allCards = LoadAllCards(); // Метод для загрузки всех карт
            UpdateCardLists();
        }

        private void InitializeComponent()
        {
            this.listBoxMyCards = new System.Windows.Forms.ListBox();
            this.listBoxAllCards = new System.Windows.Forms.ListBox();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.btnRemoveCard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMyCards
            // 
            this.listBoxMyCards.FormattingEnabled = true;
            this.listBoxMyCards.Location = new System.Drawing.Point(12, 12);
            this.listBoxMyCards.Name = "listBoxMyCards";
            this.listBoxMyCards.Size = new System.Drawing.Size(200, 150);
            this.listBoxMyCards.TabIndex = 0;
            // 
            // listBoxAllCards
            // 
            this.listBoxAllCards.FormattingEnabled = true;
            this.listBoxAllCards.Location = new System.Drawing.Point(250, 12);
            this.listBoxAllCards.Name = "listBoxAllCards";
            this.listBoxAllCards.Size = new System.Drawing.Size(200, 150);
            this.listBoxAllCards.TabIndex = 1;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(220, 50);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(20, 50);
            this.btnAddCard.TabIndex = 2;
            this.btnAddCard.Text = "→";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // btnRemoveCard
            // 
            this.btnRemoveCard.Location = new System.Drawing.Point(220, 120);
            this.btnRemoveCard.Name = "btnRemoveCard";
            this.btnRemoveCard.Size = new System.Drawing.Size(20, 50);
            this.btnRemoveCard.TabIndex = 3;
            this.btnRemoveCard.Text = "←";
            this.btnRemoveCard.UseVisualStyleBackColor = true;
            this.btnRemoveCard.Click += new System.EventHandler(this.btnRemoveCard_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 180);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DeckForm
            // 
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveCard);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.listBoxAllCards);
            this.Controls.Add(this.listBoxMyCards);
            this.Name = "DeckForm";
            this.Text = "Редактирование колоды";
            this.ResumeLayout(false);
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            if (myCards.Count < MaxCards)
            {
                Card selectedCard = (Card)listBoxAllCards.SelectedItem;
                if (selectedCard != null && !myCards.Contains(selectedCard))
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

        private void btnRemoveCard_Click(object sender, EventArgs e)
        {
            Card selectedCard = (Card)listBoxMyCards.SelectedItem;
            if (selectedCard != null)
            {
                myCards.Remove(selectedCard);
                UpdateCardLists();
            }
            else
            {
                MessageBox.Show("Выберите карту из вашего списка.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void UpdateCardLists()
        {
            listBoxMyCards.DataSource = null;
            listBoxMyCards.DataSource = myCards;
            listBoxAllCards.DataSource = null;
            listBoxAllCards.DataSource = allCards;
        }

        private List<Card> LoadAllCards()
        {
            return new AllCards().Cards;
        }

        private System.Windows.Forms.ListBox listBoxMyCards;
        private System.Windows.Forms.ListBox listBoxAllCards;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Button btnRemoveCard;
        private System.Windows.Forms.Button btnBack;
    }
}

