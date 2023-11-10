using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog
{
    public class Singer
    {
        public string Name { get; set; } = string.Empty;
        public List<Album> Albums { get; set; } = new List<Album>();
    }

    public class Album
    {
        public string Name { get; set; } = string.Empty;
        public int Year { get; set; } = 0;
        public List<Song> Songs { get; set; } = new List<Song>();

    }

    public class Song
    {
        public string Name { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
    }

    public class Songbook
    {
        public string Name { get; set; } = string.Empty;
        public List<Song> Songs { get; set; } = new List<Song>();
    }

}
