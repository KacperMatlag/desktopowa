using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola
{
    public static class FileHandling
    {
        public static List<DataRecord> GetRecords()
        {
            List<string> texts = new(File.ReadAllLines("Data.txt"));
            List<DataRecord> elements = new();

            texts = texts.Where(z => z != "").ToList();

            for(int i = 0; i < texts.Count; i+=5)
            {
                elements.Add(new DataRecord
                {
                    Artist = texts[i],
                    Album = texts[i + 1],
                    SongsNumber = int.Parse(texts[i + 2]),
                    Year = int.Parse(texts[i + 3]),
                    DownloadTime = int.Parse(texts[i + 4]),
                });
            }

            return elements;
        }
        public static void PrintElements(List<DataRecord> list)
        {
            foreach(DataRecord record in list)
            {
                Console.WriteLine(record.Artist);
                Console.WriteLine(record.Album);
                Console.WriteLine(record.SongsNumber.ToString());
                Console.WriteLine(record.Year.ToString());
                Console.WriteLine(record.DownloadTime.ToString());
                Console.WriteLine();
            }
        }

    }
}
