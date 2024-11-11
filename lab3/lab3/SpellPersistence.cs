using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace lab3
{
    internal class SpellPersistence : Interfaces.IPersistence<Spell>
    {
        private static readonly string path = "..\\..\\..\\cards\\spells";
        public List<Spell> LoadFromJson()
        {
            string[] cardFiles = Directory.GetFiles(path);
            var spells = new List<Spell>();
            string jsonData;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            Spell spell;
            foreach (string cardFile in cardFiles)
            {
                jsonData = File.ReadAllText(cardFile);

                spell = JsonConvert.DeserializeObject<Spell>(jsonData, options);

                spells.Add(spell);
            }
            return spells;
        }

        public void SaveToJson(Spell entity)
        {
            string fileName = $"{entity.Name}.json";
            string filePath = path + "\\" + fileName;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            string json = JsonConvert.SerializeObject(entity, options);
            File.WriteAllText(filePath, json);
        }
    }
}
