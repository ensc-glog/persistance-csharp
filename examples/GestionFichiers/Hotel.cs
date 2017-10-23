using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionFichiers
{
    [Serializable()]
    public class Hotel
    {
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }

        public Hotel() { } // Indispensable pour la sérialisation XML

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
