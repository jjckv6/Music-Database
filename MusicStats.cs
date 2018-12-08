using System;
namespace Music-Database
{
    public class MusicStats
    {
        public string Name;
        public string Artist;
        public string Album;
        public string Genre;
        public float Size;
        public float Time;
        public int Year;
        public double Plays;

        public MusicStats(string Name, string Artist, string Album, string Genre, float Size, 
                          float Time, int Year, double Plays)
        
        {
            Name = name;
            Artist = artist;
            Album = album;
            Genre = genre;
            Size = size;
            Time = time;
            Year = year;
            Plays = plays;         
        }
    }
}
