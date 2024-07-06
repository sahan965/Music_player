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
        BindingSource trackBindingSours = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSours.DataSource = albumsDAO.getAllAlbums();
            dataGridView1.DataSource = albumBindingSours;

            pictureBox1.Load("https://th.bing.com/th?id=OSK.mmcolojFE7buhJjIBgzdju5QZ98R0ToEFBsx-tLTnXSbWgQc&w=100&h=100&c=8&o=6&dpr=1.3&pid=SANGAM");


            // vedeo ply 
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"300\" height=\"200\" src=\"{0}\" " +
                        "frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/T-GXCAku5Xc";
            this.webBrowser1.DocumentText = string.Format(embed, url);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSours.DataSource = albumsDAO.searchTitile(textBox1.Text);
            dataGridView1.DataSource = albumBindingSours;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            
            //get the rou number
            int rowClicked = dataGridView.CurrentRow.Index;
           // MessageBox.Show("Row number is-"+ rowClicked);

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            pictureBox1.Load(imageURL);


            AlbumsDAO albumsDAO = new AlbumsDAO();
            trackBindingSours.DataSource = albumsDAO.getTrackForAlbum((int)dataGridView.Rows[rowClicked].Cells[0].Value);
            dataGridView2.DataSource = trackBindingSours;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAlbums addAlbums = new AddAlbums();
            addAlbums.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the DataGridView instance
            DataGridView dataGridView = (DataGridView)sender;

            // Get the row index of the clicked cell
            int rowClicked = dataGridView.CurrentRow.Index;

            // Get the video URL from the specified cell (assuming it's in column index 3)
            string videoURL = dataGridView.Rows[rowClicked].Cells[3].Value?.ToString();

            if (videoURL != null)
            {
                // Extract the video ID based on the URL format
                string videoID = GetYouTubeVideoId(videoURL);

                if (videoID != null)
                {
                    // Create the HTML content
                    string html = "<html><head>";
                    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    html += "</head><body>";
                    html += $"<iframe id='video' src='https://www.youtube.com/embed/{videoID}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
                    html += "</body></html>";

                    // Set the HTML content to the WebBrowser control
                    this.webBrowser1.DocumentText = html;
                }
                else
                {
                    // Handle the case where the video URL format is not recognized
                    MessageBox.Show("Invalid video URL format.");
                }
            }
            else
            {
                // Handle the case where the cell value is null or empty
                MessageBox.Show("No video URL found.");
            }
        }

        private string GetYouTubeVideoId(string videoUrl)
        {
            Uri uri = new Uri(videoUrl);
            string host = uri.Host;
            string query = uri.Query;
            string videoID = null;

            if (host.Contains("youtu.be"))
            {
                // Extract video ID from https://youtu.be/VIDEO_ID format
                videoID = videoUrl.Substring(videoUrl.LastIndexOf('/') + 1);
            }
            else if (host.Contains("youtube.com") && query.Contains("v="))
            {
                // Extract video ID from https://www.youtube.com/watch?v=VIDEO_ID format
                videoID = query.Substring(query.IndexOf('=') + 1);
            }

            return videoID;
        }









    }
}
