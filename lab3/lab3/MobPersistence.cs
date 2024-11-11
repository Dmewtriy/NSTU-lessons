using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace lab3
{
    internal class MobPersistence : Interfaces.IPersistence<Mob>
    {
        private static readonly string path = "..\\..\\..\\cards\\mobs";
        public List<Mob> LoadFromJson()
        {
            string[] cardFiles = Directory.GetFiles(path);
            var mobs = new List<Mob>();
            string jsonData, typeName;
            JsonElement element;
            foreach (string cardFile in cardFiles)
            {
                jsonData = File.ReadAllText(cardFile);
                element = JsonSerializer.Deserialize<JsonElement>(jsonData);
                typeName = element.GetProperty("Type").GetString();

                Mob mob;

                switch (typeName)
                {
                    case "Archer":
                        mob = JsonSerializer.Deserialize<Archer>(jsonData);
                        break;
                    case "Fly":
                        mob = JsonSerializer.Deserialize<Fly>(jsonData);
                        break;
                    case "Mage":
                        mob = JsonSerializer.Deserialize<Mage>(jsonData);
                        break;
                    case "Melee":
                        mob = JsonSerializer.Deserialize<Melee>(jsonData);
                        break;
                    case "Tank":
                        mob = JsonSerializer.Deserialize<Tank>(jsonData);
                        break;
                    default:
                        mob = JsonSerializer.Deserialize<Mob>(jsonData);
                        break;
                }

                mobs.Add(mob);
            }
            return mobs;
        }

        public void SaveToJson(Mob entity)
        {
            string fileName = $"{entity.Name}.json";
            string filePath = path + "\\" + fileName;
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(entity, options);
            File.WriteAllText(filePath, json);
        }
    }
}
