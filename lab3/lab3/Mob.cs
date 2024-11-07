using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Mob
    {
        private int hp;
        private int damage;
        private int price;
        private string name;
        private string history; // Женин таск
        public string Type => GetType().Name; // Свойство Type для указания типа
        public static readonly string path = "..\\..\\..\\cards";

        public int HP
        {
            get { return hp; }
            set
            {
                if (value > 0 && value <= 10) hp = value;
                else hp = 1;
            }
        }

        public int Damage
        {
            get { return damage; }
            set
            {
                if (value > 0 && value <= 8) damage = value;
                else damage = 1;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0 && value <= 10) price = value;
                else price = 1;
            }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else name = "Mob";
            }
        }

        public virtual void Attack(Mob enemy)
        {
            enemy.HP -= Damage;
        }

        public virtual void Attack(Fly enemy)
        {}

        public void SaveToJson()
        {
            string fileName = $"{name}.json";
            string filePath = path + "\\" + fileName;
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(filePath, json);
        }

        public static List<Mob> LoadFromJson()
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
    }
}
