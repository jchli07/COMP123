using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronautDemo
{
    class Astronaut
    {
        static private int ASTRONAUT_COUNT = 0;
        static private int THRESHOLD = 5;
        public string name { get; private set; }
        public string Nationality { get; private set; }

        private Astronaut(string name, string Nationality)
        {
            this.name = name;
            this.Nationality = Nationality ;
            
        }


        public static Astronaut CreateAstronaut (string name, string Nationality)
        {
            Astronaut Devin;
                if (ASTRONAUT_COUNT < THRESHOLD)
                {   
                    Devin = new Astronaut(name, Nationality);
                    ASTRONAUT_COUNT++;
                }
                else
                {
                    Devin = null;
                }
                return Devin;
               
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}", name, Nationality);
        }
    }
    
}
