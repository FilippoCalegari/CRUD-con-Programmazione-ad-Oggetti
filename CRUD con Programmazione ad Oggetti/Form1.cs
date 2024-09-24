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
using System.Diagnostics;
using System.Reflection;

namespace CRUD_con_Programmazione_ad_Oggetti
{
    public partial class Form1 : Form
    {
        private List <Record> artistsRecords;
        private string fileName = "./NewRecords.txt";
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
            // Salvo i contenuti delle textbox
            string artistName = tb_artistName.Text;
            string albumName = tb_albumName.Text;

            // Creo l'oggetto e lo aggiungo alla lista e alla listbox
            Record record = new Record(artistName, albumName);
            artistsRecords.Add(record);

            list_records.Items.Add($"{record.Artist} - {record.Album}");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Salvo la textbox con il nome dell'artista
            string artistName = tb_artistName.Text;

            if (tb_artistName.Text == string.Empty) // Controllo che la textbox non sia vuota
            {
                MessageBox.Show("Inserire il nome dell'artista.");
            }
            else
            {
                foreach (Record record in artistsRecords) // Scorro la lista di oggetti
                {
                    if (artistName == record.Artist) // Se l'artista nella textbox corrisponde a quello nella lista
                    {
                        // Rimuovo l'elemento dalla lista e dalla listbox
                        artistsRecords.Remove(record);
                        list_records.Items.Remove($"{record.Artist} - {record.Album}");
                        break;

                    }
                }
                MessageBox.Show("Artista e Album cancellati correttamente!");
            }
        }

        private void btn_serialize_Click(object sender, EventArgs e)
        {
            // Scrivo tutti gli elementi della lista, dentro al file
            StreamWriter sw = new StreamWriter(fileName);
            foreach (Record record in artistsRecords)
            {
               sw.WriteLine($"{record.Artist};{record.Album}");
            }
            sw.Close();

            MessageBox.Show("Il file è stato salvato correttamente.");
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            // Salvo la textbox con il nome dell'artista
            string artistName = tb_artistName.Text;

            if (list_records.Items.Count == 0)
            {
                MessageBox.Show("La lista è vuota.");
            }
            else
            {
                for (int i = 0; i < list_records.Items.Count; i++)
                {
                    if (artistName == artistsRecords[i].Artist)
                    {
                        list_records.SelectedIndex = i;
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Chiude il form
            Application.Exit();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Salvo i contenuti delle textbox
            string artistName = tb_artistName.Text;
            string albumName = tb_albumName.Text;
            string newArtistName = tb_newArtistName.Text;
            string newAlbumName = tb_newAlbumName.Text;

            if (tb_artistName.Text == string.Empty || tb_albumName.Text == string.Empty) // Controllo che la textbox non sia vuota
            {
                MessageBox.Show("Inserire il nome dell'artista e dell'album.");
            }
            else
            {
                foreach (Record record in artistsRecords) // Scorro la lista di oggetti
                {
                    if (record.Artist == artistName && record.Album == albumName) // Se l'artista nella textbox corrisponde a quello nella lista
                    {
                        // Rimuovo l'elemento dalla listbox
                        list_records.Items.Remove($"{record.Artist} - {record.Album}");

                        // Aggiorno l'oggetto con i nuovi nomi
                        record.Artist = newArtistName;
                        record.Album = newAlbumName;

                        // Lo inserisco di nuovo nella listbox
                        list_records.Items.Add($"{record.Artist} - {record.Album}");

                        MessageBox.Show("Artista e Album modificati correttamente!");
                        break;
                    }
                }
            }
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                string percorso = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName); //Dichiarazione percorso (variabile necessaria per il processo di apertura del file)
                Process.Start(percorso); //Avvio del processo "percorso"
            }
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