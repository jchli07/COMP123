using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronautDemo
{
    class program
    {
        static void Main(string[] args)
        { 
            List<Astronaut> astro = new List<Astronaut>();
            astro.Add(Astronaut.CreateAstronaut("Devin", "Canadian"));
            astro.Add(Astronaut.CreateAstronaut("Jeffrey", "Canadian"));
            astro.Add(Astronaut.CreateAstronaut("James", "Canadian"));
            astro.Add(Astronaut.CreateAstronaut("Daniel", "Canadian"));
            astro.Add(Astronaut.CreateAstronaut("Brandon", "Canadian"));
            astro.Add(Astronaut.CreateAstronaut("Kris", "Canadian"));

            foreach (Astronaut a in astro)
            {
                Console.WriteLine(a);
            }
        }
    }
}
