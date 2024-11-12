using System.Collections.Generic;

namespace lab3
{
    internal class AllCards
    {
        public List<Mob> Mobs { get; }
        public List<Spell> Spells { get; }

        public AllCards()
        {
            MobPersistence mobPersistence = new MobPersistence();
            SpellPersistence spellPersistence = new SpellPersistence();
            Mobs = mobPersistence.LoadFromJson();
            Spells = spellPersistence.LoadFromJson();
        }
    }
}