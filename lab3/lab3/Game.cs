using Newtonsoft.Json;
using System;
using System.IO;

namespace lab3
{
    public class Game
    {
        public static AllCards allCards { get; } = new AllCards();
        private Player player1;
        private Player player2;
        public Player Player1
        {
            get { return player1; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Player1 cannot be null.");
                player1 = value;
            }
        }

        public Player Player2
        {
            get { return player2; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Player2 cannot be null.");
                player2 = value;
            }
        }

        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
            Player1.IsPlayerTurn = new Random().Next(2) == 0; // Случайный выбор, кто начинает
            Player2.IsPlayerTurn = !Player1.IsPlayerTurn;
        }

        public void SwitchTurn()
        {
            Player1.IsPlayerTurn = !Player1.IsPlayerTurn;
            Player2.IsPlayerTurn = !Player2.IsPlayerTurn;
        }

        public void SaveGame()
        {
            string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".json";
            string filePath = "..\\..\\..\\gameSave\\" + fileName;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All , Formatting = Formatting.Indented};
            string json = JsonConvert.SerializeObject(this, options);
            File.WriteAllText(filePath, json);
        }

        public static Game LoadGame(string saveName) 
        {
            string[] saves = Directory.GetFiles("..\\..\\..\\gameSave");
            string save = saves[Array.IndexOf(saves, "..\\..\\..\\gameSave\\" + saveName + ".json")];
            string jsonData;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All , Formatting = Formatting.Indented };
            jsonData = File.ReadAllText(save);
            Game game = JsonConvert.DeserializeObject<Game>(jsonData, options);
            return game;
        }

        public static string[] GetSaves()
        {
            string[] saves = Directory.GetFiles("..\\..\\..\\gameSave");
            for(int i = 0; i < saves.Length; i++)
            {
                saves[i] = Path.GetFileNameWithoutExtension(saves[i]);
            }
            return saves;
        }
    }
}
