using System;

namespace lecture_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's create a song! Please, enter the Title, song length in minutes, Author's name and Album year:");
            string title = Console.ReadLine();
            int minutes = int.Parse(Console.ReadLine());
            string author = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            Song mySong = new Song(title, minutes, author, year);
            var data = GetSongData(mySong);
            Console.WriteLine(data);
        }
        
        public static var GetSongData(Song song)
        {
            var data = new
                {
                Title = song.Title, 
                Minutes = song.Minutes, 
                Year = song.Year
                };
            return data;
        }
    }
}
