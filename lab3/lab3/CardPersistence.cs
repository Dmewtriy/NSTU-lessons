using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace lab3
{
    internal class CardPersistence : Interfaces.IPersistence<Card>
    {
        private static readonly string path = "..\\..\\..\\cards";
        public List<Card> LoadFromJson()
        {
            string[] cardFiles = Directory.GetFiles(path);
            var cards = new List<Card>();
            string jsonData;
            Card card;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            foreach (string cardFile in cardFiles)
            {
                jsonData = File.ReadAllText(cardFile);
                card = JsonConvert.DeserializeObject<Card>(jsonData, options);

                cards.Add(card);
            }
            return cards;
        }

        public void SaveToJson(Card entity)
        {
            string fileName = $"{entity.Name}.json";
            string filePath = path + "\\" + fileName;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            string json = JsonConvert.SerializeObject(entity, options);
            File.WriteAllText(filePath, json);
        }
    }
}
