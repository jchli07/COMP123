using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SongDemo
{
    class Library
    {
        static List<Song> songs = new List<Song>();

        public static void DisplaySongs()
        {
            foreach(Song s in songs)
            {
                Console.WriteLine(s);
            }
        }
        public static void DisplaySongs(double longerThan)
        {
            foreach (Song s in songs)
            {
                if (s.Length < longerThan)
                    Console.WriteLine(s);
            }
        }
        public static void DisplaySongs(SongGenre Genre)
        {
            foreach (Song s in songs)
            {
                if (s.Genre == Genre)
                Console.WriteLine(s);
            }
        }
        public static void DisplaySongs(string Artist)
        {
            foreach (Song s in songs)
            {
                if (s.Artist == Artist)
                    Console.WriteLine(s);
            }
        }
        public static void LoadSongs(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
           
            string title;
            string artist;
            string length;
            string genre;
            

            title = reader.ReadLine();
            
            while (title != null)
            {
                artist = reader.ReadLine();
                length = reader.ReadLine();
                genre = reader.ReadLine();
             songs.Add(new Song(title, artist, double.Parse(length), (SongGenre)Enum.Parse(typeof(SongGenre), genre, false)));
                title = reader.ReadLine();
            }
        }     
    }
}
