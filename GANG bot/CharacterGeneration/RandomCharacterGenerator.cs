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

            this.strengthAbil = GenerateStat();
            this.dexterityAbil = GenerateStat();
            this.constitutionAbil = GenerateStat();
            this.intelligenceAbil = GenerateStat();
            this.wisdomAbil = GenerateStat();
            this.charismaAbil = GenerateStat();
        }

        private int GenerateStat()
        {
            Random rand = new Random();

            var rolls = Enumerable.Repeat(0,3).Select(i =>rand.Next(1,6)).ToList();

            return rolls.OrderBy(r => r).Take(3).Sum();
        }
    
    }
}
