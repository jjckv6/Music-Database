using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Music-Database
{
    public static class MusicStatsReport
    {
        public static string GenerateText(List<MusicStats> musicStatsList)
        {
            string report = "Music Playlist Report\n\n";

            if (musicStatsList.Count() < 1)
            {
                report += "No data is available.\n";

                return report;
            }

            var leastPlays = (from MusicStats in musicStatsList select musicStats.plays).Min();
            var mostPlays = (from MusicStats in musicStatsList select musicStats.plays).Max();

            report += $"Period: {leastPlays}-{mostPlays} ({musicStatsList.Count} plays)\n";


            report += "Number of songs with >= 200: ";
            var plays = from MusicStats in musicStatsList where MusicStats.Plays >= 200 select MusicStats.Plays;
            if (plays.Count() > 0)
            {
                foreach (var plays in Plays)
                {
                    report += Name:[0] + "," Artist:[1] + "," Album:[2] + "," Genre:[3] + "," Size:[4] + "," Time:[5] + "," Year:[6] + "," Plays:[7] + "\n";

                }
                report.TrimEnd(',');
                report += "\n";
            }
            else
            {
                report += "not available\n";
            }

            report += "Number of Altnerative songs:";
            var genre = from MusicStats in musicStatsList where musicStats.Genre == Alternative select MusicStats;
            if (genre.Count() > 0)
            {
                foreach (var genre in Genre)
                {
                    report += genre.Count;
                }
                report.TrimEnd(',');
                report += "\n";
            }
            else
            {
                report += "not available\n";
            }

            report += "Number of Hip-Hop/Rap songs:";
            var genre = from MusicStats in musicStatsList where musicStats.Genre == Hip-Hop/Rap select MusicStats;
            if (genre.Count() > 0)
            {
                foreach (var genre in Genre)
                {
                    report += genre.count;
                }
                report.TrimEnd(',');
                report += "\n";
            }
            else
            {
                report += "not available\n";
            }

            report += "Songs from the album Welcome to the Fishbowl: ";
            var album = from MusicStats in musicStatsList where MusicStats.Album == Welcome to the Fishbowl select MusicStats.Album;
            {
                foreach (var Album in )
                {
                    report += Name:[0] + "," Artist:[1] + "," Album:[2] + "," Genre:[3] + "," Size:[4] + "," Time:[5] + "," Year:[6] + "," Plays:[7] + "\n";

                }
                report.TrimEnd(',');
                report += "\n";
            }
            else
            {
                report += "not available\n";
            }
            
            report += "Songs from before 1970: ";
            var year = from MusicStats in musicStatsList where MusicStats.Year < 1970 select MusicStats.Year;
            {
                foreach (var year in Year)
                {
                    report += Name:[0] + "," Artist:[1] + "," Album:[2] + "," Genre:[3] + "," Size:[4] + "," Time:[5] + "," Year:[6] + "," Plays:[7] + "\n";

                }
                report.TrimEnd(',');
                report += "\n";
            }
            else
            {
                report += "not available\n";
            }
     
                report += "Song names longer than 85 characters: ";
            var name = from MusicStats in musicStatsList where MusicStats.Name > 85 select MusicStats.Name;
            {
                foreach (var name in Name)
                {
                    report += Name:[0] + "," Artist:[1] + "," Album:[2] + "," Genre:[3] + "," Size:[4] + "," Time:[5] + "," Year:[6] + "," Plays:[7] + "\n";

                }
                report.TrimEnd(',');
                report += "\n";
            }
            else
            {
                report += "not available\n";
            }
            
            report += "Longest song: ";
            var time = from MusicStats in musicStatsList where MusicStats.Time == Time.Max select MusicStats.Time;
            {
                foreach (var time in Time)
                {
                    report += Name:[0] + "," Artist:[1] + "," Album:[2] + "," Genre:[3] + "," Size:[4] + "," Time:[5] + "," Year:[6] + "," Plays:[7] + "\n";

                }
                report.TrimEnd(',');
                report += "\n";
            }
            else
            {
                report += "not available\n";
            }
     
        }
    }
}
