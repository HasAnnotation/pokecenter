using System;
using System.Collections.Generic;
using System.Text;

namespace pokecenter
{
    abstract class Pokemon
    {
        protected string name;
        protected string owner;
        protected int level;
        protected int attack;
        protected int defense;
        public abstract string Behaviour();
        public bool IsWon()
        {
            return true;
        }
        public string Status()
        {
            return $"{name} (lv. {level})  [Angriff: {attack} | Verteidigung: {defense}]";
        }
        public int Attack(ICombatReady opponent)
        {
            return this.attack;
        }

    }
}
