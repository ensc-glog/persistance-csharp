using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace GestionFichiers
{
    public partial class MainForm : Form
    {
        private Hotel hotel;

        public MainForm()
        {
            InitializeComponent();

            hotel = new Hotel("Chelsea Hotel");
            hotel.Rooms.Add(new Room(1, 0));
            hotel.Rooms.Add(new Room(2, 1));
            hotel.Rooms.Add(new Room(3, 1));
            hotel.Rooms[2].Empty = false;
        }

        private void saveBinBtn_Click(object sender, EventArgs e)
        {
            // Sauvegarde l'objet hotel dans le fichier binaire "hotel.dat"
            Stream stream = File.Open("hotel.dat", FileMode.Create);
            new BinaryFormatter().Serialize(stream, hotel);
            stream.Close();

            MessageBox.Show("Sérialisation réussie");
        }

        private void loadBinBtn_Click(object sender, EventArgs e)
        {
            // Charge le contenu du fichier "hotel.dat" dans l'objet hotel
            Stream stream = File.Open("hotel.dat", FileMode.Open);
            Hotel hotelBin = (Hotel) new BinaryFormatter().Deserialize(stream);
            stream.Close();

            MessageBox.Show(hotelBin.Name + ", " + hotelBin.Rooms.Count + " chambres");
        }

        private void saveXmlBtn_Click(object sender, EventArgs e)
        {
            // Sauvegarde l'objet hotel dans le fichier "hotel.xml"
            StreamWriter writer = new StreamWriter("hotel.xml");
            new XmlSerializer(typeof(Hotel)).Serialize(writer, hotel);
            writer.Close();

            MessageBox.Show("Sérialisation réussie");
        }

        private void loadXmlBtn_Click(object sender, EventArgs e)
        {
            // Charge le contenu du fichier "hotel.xml" dans l'objet hotel
            StreamReader reader = new StreamReader("hotel.xml");
            Hotel hotelXml = (Hotel) new XmlSerializer(typeof(Hotel)).Deserialize(reader);
            reader.Close();

            MessageBox.Show(hotelXml.Name + ", " + hotelXml.Rooms.Count + " chambres");
        }

        private void saveJsonBtn_Click(object sender, EventArgs e)
        {
            // Sauvegarde l'objet hotel dans le fichier "hotel.json"
            StreamWriter writer = new StreamWriter("hotel.json");
            new JsonSerializer().Serialize(writer, hotel);
            writer.Close();

            MessageBox.Show("Sérialisation réussie");
        }

        private void loadJsonBtn_Click(object sender, EventArgs e)
        {
            // Charge le contenu du fichier "hotel.json" dans l'objet hotel
            StreamReader reader = new StreamReader("hotel.json");
            Hotel hotelJson = (Hotel) new JsonSerializer().Deserialize(reader, typeof(Hotel));
            reader.Close();

            MessageBox.Show(hotelJson.Name + ", " + hotelJson.Rooms.Count + " chambres");
        }
    }
}
