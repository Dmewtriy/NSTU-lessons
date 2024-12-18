﻿using System;
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
            btnNewGame = new Button();
            btnLoadGame = new Button();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new System.Drawing.Point(100, 50);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new System.Drawing.Size(200, 50);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "Новая игра";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += new System.EventHandler(btnNewGame_Click);
            // 
            // btnLoadGame
            // 
            btnLoadGame.Location = new System.Drawing.Point(100, 120);
            btnLoadGame.Name = "btnLoadGame";
            btnLoadGame.Size = new System.Drawing.Size(200, 50);
            btnLoadGame.TabIndex = 1;
            btnLoadGame.Text = "Загрузить игру";
            btnLoadGame.UseVisualStyleBackColor = true;
            btnLoadGame.Click += new System.EventHandler(btnLoadGame_Click);
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(400, 250);
            Controls.Add(btnLoadGame);
            Controls.Add(btnNewGame);
            Name = "MainForm";
            Text = "Главное меню";
            ResumeLayout(false);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Game game = new Game(new Player(), new Player());
            CreateGameForm newGameForm = new CreateGameForm(game);
            newGameForm.Show();
            Hide(); // Скрыть MainForm
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            LoadGameForm loadGame = new LoadGameForm();
            loadGame.Show();
            Hide(); // Скрыть MainForm
        }

        private Button btnNewGame;
        private Button btnLoadGame;
    }
}
