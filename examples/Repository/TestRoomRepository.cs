using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class TestRoomRepository : IRoomRepository
    {
        public List<Room> FindAllByHotelId(int hotelId)
        {
            List<Room> rooms = new List<Room>();
            rooms.Add(new Room(212, 2));
            rooms.Add(new Room(213, 2));
            rooms.Add(new Room(312, 3));
            rooms[2].Empty = false;
            rooms.Add(new Room(412, 4));

            return rooms;
        }
    }
}
