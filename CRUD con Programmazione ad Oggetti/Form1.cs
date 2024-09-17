using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_con_Programmazione_ad_Oggetti
{
    public partial class Form1 : Form
    {
        private List <Record> artistsRecords;
        private string fileName = "./Records.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            artistsRecords = new List<Record>();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string artistName = tb_artistName.Text;
            string albumName = tb_albumName.Text;
            Record record = new Record(artistName, albumName);
            artistsRecords.Add(record);

            list_records.Items.Add($"{record.Artist} - {record.Album}");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_serialize_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(fileName);
            foreach (Record record in artistsRecords)
            {
                sw.WriteLine($"{record.Artist};{record.Album}");
            }
            sw.Close();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadLine();

            while (line != null)
            {
                Record record = new Record(line.Split(';')[0], line.Split(';')[1]);
                artistsRecords.Add(record);
                list_records.Items.Add($"{record.Artist} - {record.Album}");
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
    class Record
    {
        private string _artist;
        public string Artist
        {
            get => _artist;
            set => _artist = value;
        }
        private string _album;
        public string Album
        {
            get => _album;
            set => _album = value;
        }
        public Record(string artist, string album)
        {
            Artist = artist;
            Album = album;
        }
    }
}