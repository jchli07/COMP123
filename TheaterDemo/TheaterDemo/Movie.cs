using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{
    class Movie
    {

        public List<string> Cast { get; private set; }
        // = new List<string>(); // how to make this a property
        public MovieGenre Genre { get; set; }
        int Length { get; set; }
        string Title { get; set; }

        public void AddActor(string actor) {
            Cast.Add(actor);
        }

        public Movie(string t, int l) {

            this.Title = t;
            this.Length = l;
            Cast = new List<string>();

        }

        public void SetGenre(MovieGenre genre) {
            Genre = genre;
        }

        public override string ToString()
        {
            
            return string.Format("Movie: {0}. Genre: {1}. Length: {2}.",Title, Genre, Length);
        }

    }
}
