using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace lab3
{
    internal class MobPersistence : Interfaces.IPersistence<Mob>
    {
        private static readonly string path = "..\\..\\..\\cards\\mobs";
        public List<Mob> LoadFromJson()
        {
            string[] cardFiles = Directory.GetFiles(path);
            var mobs = new List<Mob>();
            string jsonData;
            Mob mob;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            foreach (string cardFile in cardFiles)
            {
                jsonData = File.ReadAllText(cardFile);

                mob = JsonConvert.DeserializeObject<Mob>(jsonData, options);

                mobs.Add(mob);
            }
            return mobs;
        }

        public void SaveToJson(Mob entity)
        {
            string fileName = $"{entity.Name}.json";
            string filePath = path + "\\" + fileName;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            string json = JsonConvert.SerializeObject(entity, options);
            File.WriteAllText(filePath, json);
        }
    }
}
