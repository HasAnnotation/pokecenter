using System;
using System.Collections.Generic;
using System.Text;

namespace pokecenter
{
    public class Trainer
    {
        private string Name;


        public void PokeList()
        {


            List<Chaotic> chaos = new List<Chaotic>();

            chaos.Add(new Chaotic ("Jens", "", 50, 40, 200));
            chaos.Add(new Chaotic ("Mohammed", "", 100, 20, 5));
            chaos.Add(new Chaotic ("Holger", "", 67, 75, 150));
            chaos.Add(new Chaotic ("Fabian", "", 9, 5, 10));
            chaos.Add(new Chaotic ("Marcel", "", 70, 30, 70));
            chaos.Add(new Chaotic ("Felix", "", 40, 80, 130));
            chaos.Add(new Chaotic ("Aykut", "", 1000, 1000, 1000));



            List<Chill> chill = new List<Chill>();

            chill.Add(new Chill("Hasan", "", 69, 100, 200));
            chill.Add(new Chill("Babak", "", 50, 40, 80));
            chill.Add(new Chill("Sven", "", 25, 5, 5));
            chill.Add(new Chill("Raffael", "", 100, 30, 60));
            chill.Add(new Chill("Aman", "", 110, 150, 100));
            chill.Add(new Chill("Roman", "", 9001, 9001, 9001));



        }


    }
}
