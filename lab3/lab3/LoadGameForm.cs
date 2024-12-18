using System.Drawing;
using System.Windows.Forms;

namespace lab3
{
    public partial class LoadGameForm : Form
    {
        private ListBox listOfSaves;
        private Button btnSelect;
        public LoadGameForm()
        {
            InitializeComponent();
            UpdateSavesList();
        }

        private void InitializeComponent()
        {
            listOfSaves = new ListBox();
            btnSelect = new Button();
            SuspendLayout();

            listOfSaves.FormattingEnabled = true;
            listOfSaves.Location = new System.Drawing.Point(50, 50);
            listOfSaves.Name = "Saves";
            listOfSaves.Size = new System.Drawing.Size(400, 400);
            listOfSaves.TabIndex = 0;

            btnSelect.Location = new System.Drawing.Point(220, 500);
            btnSelect.Name = "btnSelect";
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Выбрать сохранение";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += (sender, e) => btnSelect_Click();

            ClientSize = new System.Drawing.Size(500, 550);
            Controls.Add(btnSelect);
            Controls.Add(listOfSaves);
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

        private void UpdateSavesList()
        {
            listOfSaves.DataSource = null;
            listOfSaves.DataSource = Game.GetSaves();
        }
    }
}
