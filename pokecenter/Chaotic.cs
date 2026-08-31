using System;
using System.Collections.Generic;
using System.Text;

namespace pokecenter
{
    public class Chaotic : Pokemon, ICombatReady, IHealing
    {

        public Chaotic(string name, string owner, int level, int attack, int defense) : base (name, owner, level, attack, defense)
        {
            Name = name;
            Owner = owner;
            Level = level;
            Attack = attack;
            Defense = defense;
        }

        //public Chaotic() { }

        public override void Behaviour()
        {
            Console.WriteLine($"{Name} is being a bitch");
        }


        public void Attacking()
        {

        }

        public void IHealing()
        {

        }

        public void IsWon()
        {

        }

        public void Staus()
        {

        }

    }
}
