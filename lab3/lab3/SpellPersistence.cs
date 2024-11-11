using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace lab3
{
    internal class SpellPersistence : Interfaces.IPersistence<Spell>
    {
        private static readonly string path = "..\\..\\..\\cards\\spells";
        public List<Spell> LoadFromJson()
        {
            string[] cardFiles = Directory.GetFiles(path);
            var spells = new List<Spell>();
            string jsonData, typeName;
            JsonElement element;
            foreach (string cardFile in cardFiles)
            {
                jsonData = File.ReadAllText(cardFile);
                element = JsonSerializer.Deserialize<JsonElement>(jsonData);
                typeName = element.GetProperty("Type").GetString();

                Spell spell;

                switch (typeName)
                {
                    case "HealthSpell":
                        spell = JsonSerializer.Deserialize<HealthSpell>(jsonData);
                        break;
                    case "LowAttackSpell":
                        spell = JsonSerializer.Deserialize<LowAttackSpell>(jsonData);
                        break;
                    case "UpgradeAttackSpell":
                        spell = JsonSerializer.Deserialize<UpgradeAttackSpell>(jsonData);
                        break;
                    default:
                        spell = JsonSerializer.Deserialize<Spell>(jsonData);
                        break;
                }
                spells.Add(spell);
            }
            return spells;
        }

        public void SaveToJson(Spell entity)
        {
            string fileName = $"{entity.Name}.json";
            string filePath = path + "\\" + fileName;
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(filePath, json);
        }
    }
}
