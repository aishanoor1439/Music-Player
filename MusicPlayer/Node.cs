using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class Node
    {
        public string SongName; 
        public Node Next;        
        public Node Prev;        

        public Node(string name)
        {
            SongName = name;
        }
    }
}
