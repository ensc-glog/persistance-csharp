using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repository
{
    public partial class MainForm : Form
    {
        private IRoomRepository roomRepository;
        private IHotelRepository hotelRepository;

        public MainForm(IRoomRepository roomRepository, IHotelRepository hotelRepository)
        {
            InitializeComponent();

            this.roomRepository = roomRepository;
            this.hotelRepository = hotelRepository;
        }

        private void btnListeChambres_Click(object sender, EventArgs e)
        {
            List<Room> rooms = roomRepository.FindAllByHotelId(1);

            string message = "Liste des chambres de l'hôtel 1 :\n";
            foreach(Room room in rooms)
                message += "Numéro " + room.Number + ", étage " + room.Floor + "\n";
            MessageBox.Show(message, "Liste des chambres");
        }

        private void btnListeHotels_Click(object sender, EventArgs e)
        {
            List<Hotel> hotels = hotelRepository.GetAll();

            string message = "Liste des hôtels :\n";
            foreach (Hotel hotel in hotels)
                message += hotel + "\n";
            MessageBox.Show(message, "Liste des chambres");
        }
    }
}
