using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionFichiers
{
    [Serializable()]
    public class Room
    {
        public int Number { get; set; }
        public int Floor { get; set; }
        public bool Empty { get; set; }

        public Room()
        {
            Empty = true;
        }

        public Room(int number, int floor) : this()
        {
            Number = number;
            Floor = floor;
        }
    }
}
