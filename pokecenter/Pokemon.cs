using System;
using System.Collections.Generic;
using System.Text;

namespace pokecenter
{
    public abstract class Pokemon 
    {
        public string Name;
        protected string Owner;
        protected int Level;
        protected int Attack;
        protected int Defense;


        public abstract void Behaviour();

        public Pokemon(string name, string owner, int level, int attack, int defense)
        {
            Name = name;
            Owner = owner;
            Level = level;
            Attack = attack;
            Defense = defense;

        }

        public Pokemon()
        {
            Name = "";
            Owner = "";
            Level = 0;
            Attack = 0;
            Defense = 0;
        }


        public bool IsWon()
        {
            return true;
        }
        public string Status()
        {
            return $"{Name} (lv. {Level})  [Angriff: {Attack} | Verteidigung: {Defense}]";
        }

        public int Attacking()
        {
            return Attack;
        }

    }
}
