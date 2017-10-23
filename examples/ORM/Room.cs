using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM
{
    public class Room
    {
        public virtual int Id { get; set; }
        public virtual int Number { get; set; }
        public virtual int Floor { get; set; }
        public virtual bool Empty { get; set; }
        public virtual Hotel Hotel { get; set; }

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
