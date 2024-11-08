using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Spell : Card
    {
        public static readonly string path = "..\\..\\..\\cards\\spells";
        public new int Price
        {
            get { return price; }
            set
            {
                if (value > 0 && value <= 4) price = value;
                else throw new ArgumentOutOfRangeException("Неверное значение цены");
            }
        }

        public void SaveToJson()
        {
            string fileName = $"{name}.json";
            string filePath = path + "\\" + fileName;
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(filePath, json);
        }

        public static List<Spell> LoadFromJson()
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

                switch(typeName)
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
    }
}
