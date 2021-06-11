using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Stats()
        {

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

    }

    abstract class Humanoid
    {
        public abstract Stats bonusStats { get; }
        public Stats baseStats { get; private set; }

        public virtual Stats Stats { get => baseStats + bonusStats; }

        public Humanoid(Stats stats)
        {
            this.baseStats = stats;
        }

        public override string ToString()
        {
            return Stats.ToString();
        }

        public Humanoid()
        {

        }

        public abstract string RaceName { get; }
    }
}
