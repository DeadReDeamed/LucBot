using System;
using System.Linq;

namespace GANG_bot.CharacterGeneration.Races
{
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

        public static Stats GenerateBaseStats()
        {
            Random _rand = new Random();
            Func<int> GenerateStat = () =>
            {
               
                var rolls = Enumerable.Repeat(0, 3).Select(i => _rand.Next(1, 6)).ToList();

                return rolls.OrderBy(r => r).Take(3).Sum();
            };

            return new Stats()
            {
                Strength = GenerateStat(),
                Dexterity = GenerateStat(),
                Constitution = GenerateStat(),
                Intelligence = GenerateStat(),
                Wisdom = GenerateStat(),
                Charisma = GenerateStat(),
            };
        }

        private int GenerateStat()
        {

            var rolls = Enumerable.Repeat(0, 3).Select(i => _rand.Next(1, 6)).ToList();

            return rolls.OrderBy(r => r).Take(3).Sum();

        }

    }

    abstract class Humanoid
    {
        public abstract Stats BonusStats { get; }
        public Stats BaseStats { get; set; }

        public virtual Stats Stats { get => BaseStats + BonusStats; }

        public Humanoid(Stats stats)
        {
            this.BaseStats = stats;
        }

        public override string ToString()
        {
            return RaceName;
        }

        public Humanoid()
        {

        }

        public abstract string RaceName { get; }
    }
}
