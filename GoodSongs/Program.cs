using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodSongs
{
    class Program
    {
        static void Main(string[] args)
        {
            var allSongs = new List<Song>();
            allSongs.Add(new Song("Young Jesus", "Feeling"));
            allSongs.Add(new Song("Sinai Vessel", "Antechamber"));
            allSongs.Add(new Song("Trace Mountains", "Dog Country"));
            allSongs.Add(new Song("The Sidekicks", "1940s Fighter Jet"));
            allSongs.Add(new Song("Creed", "Higher"));
            allSongs.Add(new Song("Gleemer", "Gauze"));
            allSongs.Add(new Song("Creed", "Song1"));
            allSongs.Add(new Song("Young Jesus", "Brothers"));
            allSongs.Add(new Song("Creed", "Song2"));
            allSongs.Add(new Song("Creed", "Song3"));
            allSongs.Add(new Song("Greet Death", "You're Gonna Hate What You've Done"));
            allSongs.Add(new Song("Greet Death", "Crush"));
            var goodSongs = allSongs.Where(song => song.Artist != "Creed");
            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist}: {song.Name}");
            }
        }
    }
}
