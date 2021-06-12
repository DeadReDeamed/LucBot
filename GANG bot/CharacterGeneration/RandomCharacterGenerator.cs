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
        private static string[] classes =
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

        private static string[] racesStrings =
        {
            "elf",
            "dwarf",
            "dragonborn",
            "gnome",
            "goliath",
            "half-elf",
            "halfelf",
            "half-orc",
            "halforc",
            "halfling",
            "human",
            "tabaxi",
            "tiefling",
            "aasimar"

        };

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

        public RandomCharacterGenerator(string input)
        {
            if (doesRaceExist(input))
            {
                if (input.Equals("half-elf")) { input = "halfelf"; }
                if (input.Equals("half-orc")) { input = "halforc"; }
                _rand = new Random();
                this.characterClass = classes[_rand.Next(0, classes.Length - 1)];
                this.characterRace = (Humanoid)Activator.CreateInstance(races.Find(p => p.Name.ToLower().Contains(input)));

                this.characterRace.BaseStats = Stats.GenerateBaseStats();
            } else if (doesClassExist(input))
            {
                _rand = new Random();
                this.characterClass = input.First<char>().ToString().ToUpper() + input.Substring(1);
                this.characterRace = (Humanoid)Activator.CreateInstance(Races[_rand.Next(0, Races.Count() - 1)]);

                this.characterRace.BaseStats = Stats.GenerateBaseStats();
            }
        }

        public RandomCharacterGenerator(string race, string clas)
        {
            if (race.Equals("half-elf")) { race = "halfelf"; }
            if (race.Equals("half-orc")) { race = "halforc"; }

            this.characterClass = clas.First<char>().ToString().ToUpper() + clas.Substring(1);
            this.characterRace = (Humanoid)Activator.CreateInstance(races.Find(p => p.Name.ToLower().Contains(race)));

            this.characterRace.BaseStats = Stats.GenerateBaseStats();
        }

        public static Boolean doesRaceExist(string race)
        {
            for(int i = 0; i < racesStrings.Length; i++)
            {
                if (race.Equals(racesStrings[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean doesClassExist(string clas){
            for(int i = 0; i < classes.Length; i++)
            {
                if (clas.ToLower().Equals(classes[i].ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}
