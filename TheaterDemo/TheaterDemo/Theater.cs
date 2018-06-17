using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{
    class Theater
    {
        string Name { get; set; }
        List<Show> Shows = new List<Show>();

        public void AddShow(Show show) {
            Shows.Add(show);
        }

        public void PrintShows() {
            Console.WriteLine("Print all shows");

            int i = 0;
            foreach (Show show in Shows) {
                i++;
                Console.WriteLine("     {0}: {1}",i,show);
            }
        }

        public void PrintShows(MovieDay day) {

            Console.WriteLine("Print all shows that are on the day: {0}", day);

            int i = 0;
            foreach (Show show in Shows)
            {
                if (show.Day == day)
                {
                    i++;
                    Console.WriteLine("     {0}: {1}", i, show);
                }
            }
        }

        public void PrintShows(MovieGenre genre)
        {
            Console.WriteLine("Print all shows that have the genre: {0}", genre);
            int i = 0;
            foreach (Show show in Shows)
            {
                if(show.movie.Genre.HasFlag(genre))
                {
                    i++;
                    Console.WriteLine("     {0}: {1}", i, show);
                }
            }
        }

        public void PrintShows(String actor)
        {
            Console.WriteLine("Print all shows that have the actor: {0}", actor);
            int i = 0;
            foreach (Show show in Shows)
            {
                foreach (String Actor in show.movie.Cast)
                {
                    if (Actor.ToLower() == actor.ToLower())
                    {
                        i++;
                        Console.WriteLine("     {0}: {1}", i, show);
                    }
                }
            }
        }


        public void PrintShows(Time time)
        {
            Console.WriteLine("Print all shows that have a time of: {0}",time);
            int i = 0;
            foreach (Show show in Shows)
            {
                if (show.time.Hours == time.Hours)
                {
                    i++;
                    Console.WriteLine("     {0}: {1}", i, show);
                }
            }
        }

        public Theater(string name) {
            Name = name;
        }

    }
}
