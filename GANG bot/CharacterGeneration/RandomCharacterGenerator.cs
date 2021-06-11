using GANG_bot.CharacterGeneration.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GANG_bot.CharacterGeneration
{

    class RandomCharacterGenerator
    {
        private static List<Type> races = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(Humanoid))).ToList();
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

        public int strengthAbil { get; private set; }
        public int dexterityAbil { get; private set; }
        public int constitutionAbil { get; private set; }
        public int intelligenceAbil { get; private set; }
        public int wisdomAbil { get; private set; }
        public int charismaAbil { get; private set; }

        public string characterClass { get; private set; }
        public Humanoid characterRace { get; private set; }
        public static List<Type> Races { get => races; set => races = value; }

        public Random _rand;

        public RandomCharacterGenerator()
        {
            _rand = new Random();
            this.characterClass = classes[_rand.Next(0, classes.Length - 1)];
            this.characterRace = (Humanoid) Activator.CreateInstance(Races[_rand.Next(0, Races.Count() - 1)]);

            this.characterRace.BaseStats = Stats.GenerateBaseStats();
        }

        
    }
}
