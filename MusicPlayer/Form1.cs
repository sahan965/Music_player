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
    public partial class Form1 : Form
    {
        BindingSource albumBindingSours = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSours.DataSource = albumsDAO.getAllAlbums();
            dataGridView1.DataSource = albumBindingSours;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSours.DataSource = albumsDAO.searchTitile(textBox1.Text);
            dataGridView1.DataSource = albumBindingSours;

        }
    }
}
