using GANG_bot.CharacterGeneration.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GANG_bot.CharacterGeneration
{
    [Serializable()]
    class PlayerCharacter
    {
        private Humanoid Race;
        private string playerClass;
        public Stats BaseStats { get; set; }

        public virtual Stats Stats { get => BaseStats + Race.BonusStats; }

        public PlayerCharacter(Humanoid race, string playerClass, Stats stats)
        {
            this.BaseStats = stats;
            this.Race = race;
            this.playerClass = playerClass;
        }

    }

    class Stats
    {
        public override string ToString()
        {
            return $@"str: {Strength}
dex: {Dexterity}
cons: {Constitution}
int: {Intelligence}
wis: {Wisdom}
char: {Charisma}
";
        }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public Random _rand;

        public Stats()
        {
            _rand = new Random();
        }

        public static Stats operator +(Stats a, Stats b)
        => new Stats()
        {
            Strength = a.Strength + b.Strength,
            Dexterity = a.Dexterity + b.Dexterity,
            Constitution = a.Constitution + b.Constitution,
            Intelligence = a.Intelligence + b.Intelligence,
            Wisdom = a.Wisdom + b.Wisdom,
            Charisma = a.Charisma + b.Charisma
        };

        public void GenerateBaseStats()
        {
            Random _rand = new Random();
            Func<int> GenerateStat = () =>
            {

                var rolls = Enumerable.Repeat(0, 3).Select(i => _rand.Next(1, 6)).ToList();

                return rolls.OrderBy(r => r).Take(3).Sum();
            };


            Strength = GenerateStat();
            Dexterity = GenerateStat();
            Constitution = GenerateStat();
            Intelligence = GenerateStat();
            Wisdom = GenerateStat();
            Charisma = GenerateStat();
           
        }

    }
}
