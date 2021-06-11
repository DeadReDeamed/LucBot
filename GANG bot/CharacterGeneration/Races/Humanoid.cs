using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GANG_bot.CharacterGeneration.Races
{
    class Stats
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public Stats()
        {

        }

    }

    abstract class Humanoid
    {
        public abstract Stats bonusStats { get; }
        public Stats stats { get; private set; }

        public Humanoid(Stats stats)
        {
            this.stats = stats;
        }
    }
}
