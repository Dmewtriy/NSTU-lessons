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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnEditDeck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(100, 50);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(200, 50);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnEditDeck
            // 
            this.btnEditDeck.Location = new System.Drawing.Point(100, 120);
            this.btnEditDeck.Name = "btnEditDeck";
            this.btnEditDeck.Size = new System.Drawing.Size(200, 50);
            this.btnEditDeck.TabIndex = 1;
            this.btnEditDeck.Text = "Изменить колоду";
            this.btnEditDeck.UseVisualStyleBackColor = true;
            this.btnEditDeck.Click += new System.EventHandler(this.btnEditDeck_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnEditDeck);
            this.Controls.Add(this.btnPlay);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.Show();
            this.Hide(); // Скрыть MainForm
        }

        private void btnEditDeck_Click(object sender, EventArgs e)
        {
            DeckForm deckForm = new DeckForm();
            deckForm.Show();
            this.Hide(); // Скрыть MainForm
        }

        private Button btnPlay;
        private Button btnEditDeck;
    }
}
