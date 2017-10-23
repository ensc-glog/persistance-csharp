using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class HotelRepository : IHotelRepository
    {
        private IRoomRepository roomRepository;

        public HotelRepository(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }

        public List<Hotel> GetAll()
        {
            List<Hotel> hotels = new List<Hotel>();

            MySqlConnection connexion = Connecter();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM hotel", connexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Hotel hotel = new Hotel(reader["hotel_name"].ToString());
                hotel.Id = Convert.ToInt32(reader["hotel_id"]);
                hotel.Rooms = roomRepository.FindAllByHotelId(hotel.Id);
                hotels.Add(hotel);
            }
            reader.Close();
            connexion.Close();

            return hotels;
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
