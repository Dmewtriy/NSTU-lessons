using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Mob : Card, Interfaces.IGetDamage
    {
        private int hp;
        private int damage;
        public static readonly string path = "..\\..\\..\\cards\\mobs";

        public int Hp
        {
            get { return hp; }
            set
            {
                if (value > 0 && value <= 10) hp = value;
                else throw new ArgumentOutOfRangeException("Неверное значение здоровья");
            }
        }

        public int Damage
        {
            get { return damage; }
            set
            {
                if (value > 0 && value <= 8) damage = value;
                else throw new ArgumentOutOfRangeException("Неверное значение урона");
            }
        }

        public abstract void Attack(Mob enemy);


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

        public abstract void GetDamage(Archer archer);
        public abstract void GetDamage(Fly fly);
        public abstract void GetDamage(Mage mage);
        public abstract void GetDamage(Melee melee);
        public abstract void GetDamage(Tank tank);
    }
}
