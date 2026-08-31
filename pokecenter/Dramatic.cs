using System;
using System.Collections.Generic;
using System.Text;

namespace pokecenter
{
    public class Dramatic : Pokemon
    {
        public Dramatic(string Name, string Owner, int Level, int Attack, int Defense)
        {
            this.name = Name;
            this.owner = Owner;
            this.level = Level;
            this.attack = Attack;
            this.defense = Defense; 
        }
        public override string Behaviour()
        {
            return "Rastet bei dem kleinsten Kratzer schon aus und heult";
        }


    }
}
