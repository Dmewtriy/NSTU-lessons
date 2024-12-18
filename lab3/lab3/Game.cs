using Newtonsoft.Json;
using System;
using System.IO;

namespace lab3
{
    internal class Game
    {
        private readonly AllCards allCards = new AllCards();
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
        }

        public void SaveGame()
        {
            string fileName = $"{DateTime.Now}.json";
            string filePath = "..\\..\\..\\gameSave\\" + fileName;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            string json = JsonConvert.SerializeObject(this, options);
            File.WriteAllText(filePath, json);
        }

        public Game LoadGame(string saveName) 
        {
            string[] saves = Directory.GetFiles("..\\..\\..\\gameSave");
            string save = saves[Array.IndexOf(saves, saveName)];
            string jsonData;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            jsonData = File.ReadAllText(save);
            Game game = JsonConvert.DeserializeObject<Game>(jsonData, options);
            return game;
        }
    }
}
