using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string artistName = tb_artistName.Text.ToString();
            string albumName = tb_albumName.Text.ToString();
            Record record = new Record(artistName, albumName);

            list_records.Items.Add(record.Artist, record.Album);
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