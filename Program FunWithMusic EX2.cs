using System;

namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Rock,
            Pop,
            Jazz,
            Classical,
            HipHop
        }

        struct Music
        {
            private string _Title;
            private string _Artist;
            private string _Album;
            private string _Length;
            private Genre _Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                _Title = title;
                _Artist = artist;
                _Album = album;
                _Length = length;
                _Genre = genre;
            }

            public void setTitle(string title)
            {
                _Title = title;
            }

            public void setLength(string length)
            {
                _Length = length;
            }

            public string Display()
            {
                return $"Title: {_Title}\nArtist: {_Artist}\nAlbum: {_Album}\nLength: {_Length}\nGenre: {_Genre}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of the song?");
            string tempTitle = Console.ReadLine();

            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();

            Console.WriteLine("What is the album name?");
            string tempAlbum = Console.ReadLine();

            Console.WriteLine("What is the song length (e.g., 3:45)?");
            string tempLength = Console.ReadLine();

            Console.WriteLine("What is the genre of the song?");
            Console.WriteLine("R - Rock\nP - Pop\nJ - Jazz\nC - Classical\nH - HipHop");
            Genre tempGenre = Genre.Rock;
            char g = char.Parse(Console.ReadLine());



            switch (g)
            {
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'C':
                    tempGenre = Genre.Classical;
                    break;
                case 'H':
                    tempGenre = Genre.HipHop;
                    break;
                default:
                    tempGenre = Genre.Rock;
                    break;
            }

            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);

            Console.WriteLine("\nMusic Information:");
            Console.WriteLine(music.Display());

            



            Music moreMusic = music;

            Console.WriteLine("\nEnter details for another song from the same album:");
            Console.WriteLine("New song title:");
            moreMusic.setTitle(Console.ReadLine());

            Console.WriteLine("New song length (e.g., 3:30):");
            moreMusic.setLength(Console.ReadLine());

            Console.WriteLine("\nFirst Song:");
            Console.WriteLine(music.Display());

            Console.WriteLine("\nSecond Song:");
            Console.WriteLine(moreMusic.Display());
        }
    }
}
