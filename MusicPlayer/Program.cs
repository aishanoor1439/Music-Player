using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicPlayer player = new MusicPlayer();

            player.AddSong("Unstoppable – Sia");
            player.AddSong("Believer – Imagine Dragons");
            player.AddSong("Thunder – Imagine Dragons");
            player.AddSong("Whatever It Takes – Imagine Dragons");

            player.DisplayPlaylist();
            Console.WriteLine();

            Console.WriteLine("▶ Starting music...");
            Console.WriteLine($"Now playing: {player.current.SongName}");
            Console.WriteLine();

            player.PlayNext();       
            player.PlayNext();       
            player.PlayPrevious();   

            Console.WriteLine();
            player.DeleteSong("Believer"); 
            Console.WriteLine();
            player.DisplayPlaylist();
        }
    }
}
