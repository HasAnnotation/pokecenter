using System;
using System.Collections.Generic;
using System.Text;

namespace pokecenter
{
    public class Sneaky : Pokemon
    {
        public Sneaky(string Name, string Owner, int Level, int Attack, int Defense)
        {
            this.name = Name;
            this.owner = Owner;
            this.level = Level;
            this.attack = Attack;
            this.defense = Defense;
        }
        public override string Behaviour()
        {
            return "Ist halt einfach da aber niemand merkt es";
        }
    }
}
