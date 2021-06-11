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
        private static List<string> races = (from type in Assembly.GetExecutingAssembly().GetTypes()
                                             where type.IsSubclassOf(typeof(Humanoid))
                                             select type.GetProperties().First(p => p.Name == "RaceName").GetValue(Activator.CreateInstance(type))).Select(p => (string)p).ToList();
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
        public string characterRace { get; private set; }
        public static List<string> Races { get => races; set => races = value; }

        public Random _rand;

        public RandomCharacterGenerator()
        {
            _rand = new Random();
            this.characterClass = classes[_rand.Next(0, classes.Length - 1)];
            this.characterRace = Races[_rand.Next(0, Races.Count() - 1)];

            this.strengthAbil = GenerateStat();
            this.dexterityAbil = GenerateStat();
            this.constitutionAbil = GenerateStat();
            this.intelligenceAbil = GenerateStat();
            this.wisdomAbil = GenerateStat();
            this.charismaAbil = GenerateStat();
        }

        private int GenerateStat()
        { 
            
            var rolls = Enumerable.Repeat(0,3).Select(i =>_rand.Next(1,6)).ToList();

            return rolls.OrderBy(r => r).Take(3).Sum();

        }
    
    }
}
