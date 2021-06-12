using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GANG_bot.CharacterGeneration.Races
{
    class Elf : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Dexterity = 2 };}

        public override string RaceName => "Elf";

        public Elf(Stats stats) : base(stats)
        {
                 
        }

        public Elf() : base()
        {

        }

    }

    class Human : Humanoid
    {
        public override Stats BonusStats { get => new Stats() {Strength = 1, Dexterity = 1, Charisma = 1, Constitution = 1, Intelligence = 1, Wisdom = 1};}

        public override string RaceName => "Human";

        public Human(Stats stats) : base(stats)
        {
              
        }

        public Human() : base()
        {
               
        }
    }

    class Dragonborn : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Strength = 2, Charisma = 1 }; }

        public override string RaceName => "Dragonborn";

        public Dragonborn(Stats stats) : base(stats)
        {

        }

        public Dragonborn() : base()
        {

        }
    }

    class Dwarf : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Constitution = 2 }; }

        public override string RaceName => "Dwarf";

        public Dwarf(Stats stats) : base(stats)
        {
              
        }

        public Dwarf() : base()
        {

        }
    }

    class Gnome : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Intelligence = 2 }; }

        public override string RaceName => "Gnome";

        public Gnome(Stats stats) : base(stats)
        {
             
        }

        public Gnome() : base()
        {

        }
    }

    class Goliath : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Strength = 2, Constitution = 1 }; }

        public override string RaceName => "Goliath";

        public Goliath(Stats stats) : base(stats)
        {

        }

        public Goliath() : base()
        {

        }
    }

    class HalfElf : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Charisma = 2, Intelligence = 1, Dexterity = 1 }; }

        public override string RaceName => "Half-elf";

        public HalfElf(Stats stats) : base(stats)
        {

        }

        public HalfElf() : base()
        {
                
        }
    }

    class HalfOrc : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Strength = 2, Constitution = 1}; }

        public override string RaceName => "Half-orc";

        public HalfOrc(Stats stats) : base(stats)
        {

        }

        public HalfOrc() : base()
        {

        }
    }

    class Halfling : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Dexterity = 2 }; }

        public override string RaceName => "Halfling";

        public Halfling(Stats stats) : base(stats)
        {

        }

        public Halfling() : base()
        {
                
        }
    }

    class Tabaxi : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Dexterity = 2, Charisma = 1 }; }

        public override string RaceName => "Tabaxi";

        public Tabaxi(Stats stats) : base(stats)
        {

        }

        public Tabaxi() : base()
        {

        }
    }

    class Tiefling : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Charisma = 2, Intelligence = 1 }; }

        public override string RaceName => "Tiefling";

        public Tiefling(Stats stats) : base(stats)
        {

        }

        public Tiefling() : base()
        {

        }
    }

    class Aasimar : Humanoid
    {
        public override Stats BonusStats { get => new Stats() { Charisma = 2 }; }

        public override string RaceName => "Aasimar";

        public Aasimar(Stats stats) : base(stats)
        {

        }

        public Aasimar() : base()
        {

        }
    }
}
