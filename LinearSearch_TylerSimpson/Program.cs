namespace LinearSearch_TylerSimpson
{
    internal class Program
    {

        // Declare the global arrays

        static string[] artistAlbum;
        static string[] genre;
        static Artist[] artists;

        static void Main(string[] args)
        {

            Preload();

            ExampleCode();
        }

        public static bool ContainsAlbum(string[] artistList, string searchKey)
        {
            foreach (string album in artistList)
            {
                if (album == searchKey)
                {
                    return true;
                }
            }
            return false;
        }
        public static int ArtistByGenre(string[] artistList, string searchKey)
        {
            for (int i = 0; i < artistList.Length; i++)
            {
                if (artistList[i] == searchKey)
                {
                    return i;
                }
            }
            return -1; // Return -1 if not found
        }
        public static List<int> AllArtistsOfAGenre(string[] artistList, string searchKey)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < artistList.Length; i++)
            {
                if (genre[i] == searchKey)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }
        public static List<Artist> AllGenresOfArtist(Artist[] artistList, string searchKey)
        {
            List<Artist> artistsInGenre = new List<Artist>();
            foreach (Artist genre in artistList)
            {
                if (genre.Genre[0].ToString() == searchKey)
                {
                    artistsInGenre.Add(genre);
                }
            }
            return artistsInGenre;
        }


        static void Preload()
        {
            artistAlbum = new string[]
            {
            "Tiphop",
            "Apophenia",
            "Do Your Thing",
            "Museum of Consciousness",
            "Arise",
            };

            genre = new string[]
            {
            "Tiphop",          // Tipper
            "Bass",            // Mr Bill
            "Funk",            // The Floozies
            "Psytrance",       // Shpongle
            "Funk",            // Sunsquabi
            };

            artists = new Artist[]
            {
            new Artist("Tipper", "Tiphop", "Tiphop"),
            new Artist("Mr Bill", "Apophenia", "Bass"),
            new Artist("The Floozies", "Do Your Thing", "Funk"),
            new Artist("Shpongle", "Museum of Consciousness", "Psytrance"),
            new Artist("Sunsquabi", "Arise", "Funk"),
            };
        }
        static void ExampleCode()
        {
            Console.WriteLine("Contains");
            Console.WriteLine(ContainsAlbum(artistAlbum, "Tiphop").ToString()); // True
            Console.WriteLine(ContainsAlbum(artistAlbum, "Fathoms").ToString()); // False

            Console.WriteLine("Genre By Index");
            Console.WriteLine(ArtistByGenre(genre, "Bass").ToString()); // 1
            Console.WriteLine(ArtistByGenre(genre, "Rock").ToString()); // -1

            Console.WriteLine("All artists of a genre");
            Console.WriteLine(AllArtistsOfAGenre(genre, "Funk").Count); // 2
            Console.WriteLine(AllArtistsOfAGenre(genre, "Ska").Count); // 0

            Console.WriteLine("All genres of an artist");
            List<Artist> genreResults = AllGenresOfArtist(artists, "The Floozies");
            Console.WriteLine(genreResults.Count); // 1
            foreach (Artist artists in genreResults) { Console.WriteLine($"{artists.Name} - {artists.Genre}"); }
            Console.WriteLine(AllGenresOfArtist(artists, "Punk").Count); // 0
        }

    }
}
