using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace lab3
{
    public partial class LoadGameForm : Form
    {
        private ListBox listOfSaves;
        private Button btnSelect;
        private Button btnDelete;
        public LoadGameForm()
        {
            InitializeComponent();
            UpdateSavesList();
        }

        private void InitializeComponent()
        {
            listOfSaves = new ListBox();
            btnSelect = new Button();
            btnDelete = new Button();
            SuspendLayout();

            listOfSaves.FormattingEnabled = true;
            listOfSaves.Location = new System.Drawing.Point(50, 50);
            listOfSaves.Name = "Saves";
            listOfSaves.Size = new System.Drawing.Size(400, 400);
            listOfSaves.TabIndex = 0;

            btnSelect.Location = new System.Drawing.Point(100, 480);
            btnSelect.Name = "btnSelect";
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Загрузить сохранение";
            btnSelect.Size = new Size(120, 50);
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += (sender, e) => btnSelect_Click();

            btnDelete.Location = new System.Drawing.Point(280, 480);
            btnDelete.Name = "btnDelete";
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Удалить сохранение";
            btnDelete.Size = new Size(120, 50);
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += (sender, e) => btnDelete_Click();

            ClientSize = new System.Drawing.Size(500, 550);
            Controls.Add(btnSelect);
            Controls.Add(listOfSaves);
            Controls.Add(btnDelete);
            Name = "LoadGame";
            Text = "Загрузка сохранения игры";
            ResumeLayout(false);
        }

        private void btnSelect_Click()
        {
            Game game = Game.LoadGame(listOfSaves.SelectedItem as string);
            PlayForm playForm = new PlayForm(game);
            Hide();
            playForm.Show();
        }

        private void btnDelete_Click()
        {
            File.Delete("..\\..\\..\\gameSave\\" + listOfSaves.SelectedItem + ".json");
            UpdateSavesList();
        }

        private void UpdateSavesList()
        {
            listOfSaves.DataSource = null;
            listOfSaves.DataSource = Game.GetSaves();
        }
    }
}
