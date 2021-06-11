using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GANG_bot.CharacterGeneration
{

    class RandomCharacterGenerator
    {
        private string[] classes =
        {
            "Barbarian",
            "Ranger",
            "Cleric",
            "Bard",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"
        };
        private string[] races =
        {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Gnome",
            "Goliath",
            "Half-Elf",
            "Human",
            "Tabaxi",
            "Tiefling",
            "Aasimar"
        };

        public int strengthAbil { get; private set; }
        public int dexterityAbil { get; private set; }
        public int constitutionAbil { get; private set; }
        public int intelligenceAbil { get; private set; }
        public int wisdomAbil { get; private set; }
        public int charismaAbil { get; private set; }

        public string characterClass { get; private set; }
        public string characterRace { get; private set; }

        public RandomCharacterGenerator()
        {
            Random random = new Random();
            this.characterClass = classes[random.Next(0, classes.Length - 1)];
            this.characterRace = races[random.Next(0, races.Length - 1)];

            this.strengthAbil = random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6);
            this.dexterityAbil = random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6);
            this.constitutionAbil = random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6);
            this.intelligenceAbil = random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6);
            this.wisdomAbil = random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6);
            this.charismaAbil = random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6);
        }
    
    }
}
