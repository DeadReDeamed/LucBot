using System;
using System.Linq;
using GANG_bot.CharacterGeneration;

namespace GANG_bot.CharacterGeneration.Races
{

    [Serializable()]
    abstract class Humanoid
    {
        public abstract Stats BonusStats { get; }
        

        

        public Humanoid(Stats stats)
        {
            
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
