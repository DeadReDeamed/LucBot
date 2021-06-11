using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GANG_bot.CharacterGeneration.Races
{
    class Elf : Humanoid
    {
        public override Stats bonusStats { get => new Stats() { Dexterity = 2 };}

        public Elf(Stats stats) : base(stats)
        {
                
        }
    }
}
