using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class Room
    {
        public int Id { get; set; }
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
