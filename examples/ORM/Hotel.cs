using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM
{
    public class Hotel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Room> Rooms { get; set; }

        public Hotel()
        {
            Rooms = new List<Room>();
        }

        public override string ToString()
        {
            return Name + ", " + Rooms.Count + " chambres";
        }
    }
}
