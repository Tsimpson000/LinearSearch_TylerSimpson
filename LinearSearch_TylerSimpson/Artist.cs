using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch_TylerSimpson
{
    internal class Artist
    {
        public string Name { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }

        public Artist(string name, string album, string genre)
        {
            Name = name;
            Album = album;
            Genre = genre;
        }
    }
}
