using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Repository
{
    class RoomRepository : IRoomRepository
    {
        public List<Room> FindAllByHotelId(int hotelId)
        {
            MySqlConnection connexion = Connecter();

            List<Room> rooms = new List<Room>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM room where hotel_id=@IdHotel", connexion);
            cmd.Parameters.AddWithValue("@IdHotel", hotelId);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Room room = new Room();
                room.Id = Convert.ToInt32(reader["room_id"]);
                room.Number = Convert.ToInt32(reader["room_number"]);
                room.Floor = Convert.ToInt32(reader["room_floor"]);
                room.Empty = Convert.ToBoolean(reader["room_empty"]);
                rooms.Add(room);
            }
            reader.Close();

            connexion.Close();

            return rooms;
        }

        private MySqlConnection Connecter()
        {
            string chaineCnx = "server=localhost;database=hotelDB;user=utilHotel;password=secret;";
            MySqlConnection connexion = new MySqlConnection(chaineCnx);
            connexion.Open();
            return connexion;
        }
    }
}
