using System;
using System.Collections.Generic;
using System.Text;

namespace pokecenter
{
    public class PokemonCenter : Pokemon
    {
        //public PokemonCenter(string name) => Name = name;

        public override void Behaviour()
        {
            Console.WriteLine("");
        }


        public void PokeList()
        {
           
            List<Chaotic> chaos = new List<Chaotic>();

            chaos.Add(new Chaotic("Kosturso", "", 50, 40, 200));
            chaos.Add(new Chaotic("Traumato", "", 100, 20, 5));
            chaos.Add(new Chaotic("Galar Weezing", "", 67, 75, 150));
            chaos.Add(new Chaotic("Enamorus", "", 9, 5, 10));
            chaos.Add(new Chaotic("Scream Tail ", "", 70, 30, 70));
            chaos.Add(new Chaotic("Mr. Mime", "", 40, 80, 130));
            chaos.Add(new Chaotic("Arceus", "", 1000, 1000, 1000));


            List<string> opt = new List<string>();

            foreach (var c in chaos)
            {
                opt.Add(c.Name);
            }



            List<Chill> chill = new List<Chill>();

            chill.Add(new Chill("Snorlax", "", 69, 100, 200));
            chill.Add(new Chill("Alola Geowaz", "", 50, 40, 80));
            chill.Add(new Chill("Ghastly", "", 25, 5, 5));
            chill.Add(new Chill("Probopass", "", 100, 30, 60));
            chill.Add(new Chill("Swalot", "", 110, 150, 100));
            chill.Add(new Chill("Squirtle", "", 9001, 9001, 9001));


            List<string> opt2 = new List<string>();

            foreach (var c in chill)
            {
                opt2.Add(c.Name);
            }


        }


    }
}
