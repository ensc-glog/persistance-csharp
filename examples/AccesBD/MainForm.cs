using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AccesBD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnListeChambres_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = Connecter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM room where hotel_id=@idHotel", connexion);
            cmd.Parameters.AddWithValue("@idHotel", 1);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string message = "Liste des chambres de l'hôtel 1 :\n";
                while (reader.Read())
                    message += "Numéro " + reader["room_number"] + ", étage " + reader["room_floor"] + "\n";
                MessageBox.Show(message, "Liste des chambres");
            }
            reader.Close();

            connexion.Close();
        }

        private void btnNbChambres_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = Connecter();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM room", connexion);
            int nbChambres = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("La base de données contient " + nbChambres + " chambres(s)", "Nombre de chambres");

            connexion.Close();
        }

        

        private void btnReserverChambre_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = Connecter();

            MySqlCommand cmd = new MySqlCommand("UPDATE room SET room_empty=@Empty WHERE room_number=@Number", connexion);
            cmd.Parameters.AddWithValue("@Number", 2);
            cmd.Parameters.AddWithValue("@Empty", false);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chambre 2 réservée", "Réservation d'une chambre");

            connexion.Close();
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
