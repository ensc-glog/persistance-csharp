using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }

        public Hotel(string name)
        {
            Name = name;
            Rooms = new List<Room>();
        }

        public override string ToString()
        {
            return Name + ", " + Rooms.Count + " chambres";
        }
    }
}
