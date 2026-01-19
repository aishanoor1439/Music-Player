using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class MusicPlayer
    {
        public Node head;   
        public Node current; 

        public void AddSong(string songName)
        {
            Node newSong = new Node(songName);

            if (head == null)
            {
                head = newSong;
                current = head;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newSong;
            newSong.Prev = temp;
        }

        public void PlayNext()
        {
            if (current == null)
            {
                Console.WriteLine("No song in the playlist.");
                return;
            }

            if (current.Next == null)
            {
                Console.WriteLine("Reached the end of the playlist.");
            }
            else
            {
                current = current.Next;
                Console.WriteLine($"Now playing: {current.SongName}");
            }
        }

        public void PlayPrevious()
        {
            if (current == null)
            {
                Console.WriteLine("No song in the playlist.");
                return;
            }

            if (current.Prev == null)
            {
                Console.WriteLine("You are at the beginning of the playlist.");
            }
            else
            {
                current = current.Prev;
                Console.WriteLine($"Now playing: {current.SongName}");
            }
        }

        public void DeleteSong(string songName)
        {
            if (head == null)
            {
                Console.WriteLine("Playlist is empty.");
                return;
            }

            Node temp = head;

            while (temp != null && temp.SongName != songName)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine($"Song '{songName}' not found.");
                return;
            }

            if (temp == head)
            {
                head = temp.Next;
                if (head != null)
                    head.Prev = null;
            }
            else
            {
                if (temp.Next != null)
                    temp.Next.Prev = temp.Prev;
                if (temp.Prev != null)
                    temp.Prev.Next = temp.Next;
            }

            if (current == temp)
            {
                current = temp.Next ?? temp.Prev;
            }

            Console.WriteLine($"Deleted: {songName}");
        }

        public void DisplayPlaylist()
        {
            if (head == null)
            {
                Console.WriteLine("Playlist is empty.");
                return;
            }

            Node temp = head;
            Console.WriteLine("🎵 Current Playlist:");

            while (temp != null)
            {
                if (temp == current)
                    Console.WriteLine($"→ {temp.SongName} (Currently Playing)");
                else
                    Console.WriteLine($"   {temp.SongName}");

                temp = temp.Next;
            }
        }
    }
}
