using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibContexte;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class DbHotelRepository : IHotelRepository
    {
        public Hotel FindById()
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetAll()
        {
            List<Hotel> hotels = new List<Hotel>();

            MySqlConnection connexion = Connecter();
            MySqlCommand cmdHotel = new MySqlCommand("SELECT * FROM hotel", connexion);
            MySqlDataReader readerHotel = cmdHotel.ExecuteReader();
            while (readerHotel.Read())
            {
                //TODO
                MySqlCommand cmdRoom = new MySqlCommand("SELECT * FROM room WHERE hotel_id=@IdHotel", connexion);
                MySqlDataReader readerRoom = cmdRoom.ExecuteReader();
                while (readerHotel.Read())
                {
                    
                }
                Hotel hotel = new Hotel(readerHotel["hotel_name"].ToString());
                hotels.Add(hotel);
            }
            readerHotel.Close();
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
