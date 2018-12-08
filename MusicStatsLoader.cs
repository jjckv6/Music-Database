using System;
using System.Collections.Generic;
using System.IO;

namespace Music-Database
{
    public static class MusicStatsLoader
    {
        private static int NumItemsInRow = 8;

        public static List<MusicStats> Load(string csvDataFilePath) {
            List<MusicStats> musicStatsList = new List<MusicStats>();

            try
            {
                using (var reader = new StreamReader(csvDataFilePath))
                {
                    int lineNumber = 0;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        lineNumber++;
                        if (lineNumber == 1) continue;

                        var values = line.Split(',');

                        if (values.Length != NumItemsInRow)
                        {
                            throw new Exception($"Row {lineNumber} contains {values.Length} values. It should contain {NumItemsInRow}.");
                        }
                        try
                        {
                            string name = Int32.Parse(values[0]);
                            string artist = Int32.Parse(values[1]);
                            string album  = Int32.Parse(values[2]);
                            string genre = Int32.Parse(values[3]);
                            float size = Int32.Parse(values[4]);
                            float time = Int32.Parse(values[5]);
                            int year = Int32.Parse(values[6]);
                            double plays = Int32.Parse(values[7]);
                            Musictats musicStats = new MusicStats(name,artist,album,genre,size,time,year,plays);
                            musicStatsList.Add(musicStats);
                        }
                        catch (FormatException e)
                        {
                            throw new Exception($"Row {lineNumber} contains invalid data. ({e.Message})");
                        }
                    }
                }
            } catch (Exception e){
                throw new Exception($"Unable to open {csvDataFilePath} ({e.Message}).");
            }

            return musicStatsList;
        }
    }
}
