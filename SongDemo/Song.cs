using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongDemo
{
    enum SongGenre { Unclassified, Pop, Rock, Blues, Country, Metal, Soul }   

    class Song
    {
        public string Title{get; private set;}
        public string Artist{get; private set;}
        public double Length{get; private set;}
        public SongGenre Genre{get; private set;}

        public Song (string Title, string Artist, double Length, SongGenre Genre)
        {
            this.Title = Title;
            this.Artist = Artist;
            this.Length = Length;
            this.Genre = Genre;

        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", Title, Artist, Length, Genre);
        }
       
    }

}
