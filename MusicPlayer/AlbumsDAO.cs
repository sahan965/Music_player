using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    internal class AlbumsDAO
    {
        string connectionstring = "datasource= localhost; port= 3308; username= root; password= root; database= music2";

        public List<Albums> getAllAlbums()
        {
            //empty list 
            List<Albums> returnThese = new List<Albums>();

            //Mysql connection 
            MySqlConnection connecton = new MySqlConnection(connectionstring);
            connecton.Open();

            //sql statement 
            MySqlCommand command = new MySqlCommand("SELECT * FROM Albums",connecton);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Albums a = new Albums {
                        ID = reader.GetInt32(0),
                        AlbumsName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),

                    };
                    returnThese.Add(a);
                    
                }
            }

            connecton.Close();

            return returnThese;
            
        }

        public List<Albums> searchTitile(String searchTerm)
        {
            //empty list 
            List<Albums> returnThese = new List<Albums>();

            //Mysql connection 
            MySqlConnection connecton = new MySqlConnection(connectionstring);
            connecton.Open();

            string searchwildphrase = "%" + searchTerm + "%";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID,Albums,ArtistName,Year,ImageURL,Description FROM ALBUMS WHERE Albums LIKE @search";
            command.Parameters.AddWithValue("@search", searchwildphrase);
            command.Connection = connecton;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Albums a = new Albums
                    {
                        ID = reader.GetInt32(0),
                        AlbumsName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),

                    };
                    returnThese.Add(a);

                }
            }

            connecton.Close();

            return returnThese;

        }

        internal int addOneAlbum(Albums albums)
        {
            
            //Mysql connection 
            MySqlConnection connecton = new MySqlConnection(connectionstring);
            connecton.Open();

            //sql statement 
            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`Albums`, `ArtistName`, `Year`, `ImageURL`, `Description`) VALUES (@albumname,@artist,@year,@imageurl,@description)", connecton);
            command.Parameters.AddWithValue("@albumname", albums.AlbumsName);
            command.Parameters.AddWithValue("@artist", albums.ArtistName);
            command.Parameters.AddWithValue("@year", albums.Year);
            command.Parameters.AddWithValue("@imageURL", albums.ImageURL);
            command.Parameters.AddWithValue("@description", albums.Description);

            int newRows = command.ExecuteNonQuery();
            
            connecton.Close();

            return newRows;
        }
        public List<Track> getTrackForAlbum(int albumID)
        {
            //empty list 
            List<Track> returnThese = new List<Track>();

            //Mysql connection 
            MySqlConnection connecton = new MySqlConnection(connectionstring);
            connecton.Open();

            //sql statement 
            MySqlCommand command = new MySqlCommand();
            command.CommandText="SELECT * FROM TRACKS WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connecton;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                        

                    };
                    returnThese.Add(t);

                }
            }

            connecton.Close();

            return returnThese;

        }
    }

}
