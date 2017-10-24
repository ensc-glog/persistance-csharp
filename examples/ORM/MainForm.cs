using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;

namespace ORM
{
    public partial class MainForm : Form
    {
        private ISession session;

        public MainForm()
        {
            InitializeComponent();

            ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
            session = sessionFactory.OpenSession();
        }

        private void btnListeChambres_Click(object sender, EventArgs e)
        {
            string requete = "select r from Room r where r.Hotel.Id=?";
            IList<Room> rooms = session.CreateQuery(requete).SetInt32(0,1).List<Room>();

            string message = "Liste des chambres de l'hôtel 1 :\n";
            foreach (Room room in rooms)
                message += "Numéro " + room.Number + ", étage " + room.Floor + "\n";
            MessageBox.Show(message, "Liste des chambres");
        }

        private void btnListeHotels_Click(object sender, EventArgs e)
        {
            IList<Hotel> hotels = session.Query<Hotel>().ToList();

            string message = "Liste des hôtels :\n";
            foreach (Hotel hotel in hotels)
                message += hotel + "\n";
            MessageBox.Show(message, "Liste des chambres");
        }

        private void btnNbChambres_Click(object sender, EventArgs e)
        {
            int nbChambres = (int) session.CreateQuery("select count(*) from Room").UniqueResult<long>();
            MessageBox.Show("La base de données contient " + nbChambres + " chambres(s)", "Nombre de chambres");
        }

        private void btnAjoutChambre_Click(object sender, EventArgs e)
        {
            Hotel hotel = session.Query<Hotel>().SingleOrDefault<Hotel>();

            Room room = new Room();
            room.Hotel = hotel;
            room.Number = 6667;
            room.Floor = 4;
            
            session.SaveOrUpdate(room);
            session.Flush();

            MessageBox.Show("Chambre ajoutée, Id : " + room.Id);

            room.Empty = false;

            session.SaveOrUpdate(room);
            session.Flush();

            session.Delete(room);
            session.Flush();

            MessageBox.Show("Chambre supprimée");
        }
    }
}
