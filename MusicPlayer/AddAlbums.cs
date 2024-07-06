using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class AddAlbums : Form
    {
        public AddAlbums()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add new item to the database
            Albums albums = new Albums
            {
                AlbumsName = txt_albumName.Text,
                ArtistName = txt_artist.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = txt_imageURL.Text,
                Description = txt_description.Text,

            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(albums);
            MessageBox.Show(result + "new row (s) inserted");
            
            AddAlbums addAlbums = new AddAlbums();
            this.Close();
        }
    }
}
