using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace IMDBClone
{
    public partial class Form3_MovieList : Form
    {
//###########################################################################################################################################################################
        //GLOVARS
        //
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=IMDBClone.sqlite;Version=3;");
        SQLiteCommand sql_query;
        SQLiteDataReader reader;
        int i; //need this for identifying clicked poster..
        int movieID; //needed for editing clicked poster/movie...ugh. .
        string welcome;
        string username;
        string searchstring;
        bool searchByGenre;
        //
        // /GLOVARS
//###########################################################################################################################################################################
        public Form3_MovieList()
        {
            InitializeComponent();
        }
//###########################################################################################################################################################################
        /*public Form3_MovieList(string x)
        {
            username = x;
            InitializeComponent();
            welcome = "Welcome, "+x;
        }*/
//#####################################################################################################################################################################
        public Form3_MovieList(string x,string searchstring,bool searchByGenre)
        {
            username = x;
            this.searchstring = searchstring;
            this.searchByGenre = searchByGenre;
            InitializeComponent();
            welcome = "Welcome, " + x;
        }
//###########################################################################################################################################################################
        private void Form3_MovieList_Load(object sender, EventArgs e)
        {
            //this.Refresh();

            m_label_username.Text = welcome;
            this.AutoScroll = true;

            m_dbConnection.Open();                                                          //open connection
            

            //#################CREATE TEMP TABLE#########################
            sql_query = new SQLiteCommand("drop table if exists tmp",m_dbConnection);
            sql_query.ExecuteNonQuery();
            sql_query = new SQLiteCommand("create table tmp as select rowid,* from movies where (name like '%" + searchstring + "%' or director like '%" + searchstring + "%' or actor_main like '%" + searchstring + "%' or actor_secondary like '%" + searchstring + "%')", m_dbConnection);
             sql_query.ExecuteNonQuery();
            //#################/ CREATE TEMP TABLE#########################

             sql_query = new SQLiteCommand("select count(*) from movies where (name like '%" + searchstring + "%' or director like '%" + searchstring + "%' or actor_main like '%" + searchstring + "%' or actor_secondary like '%" + searchstring + "%')", m_dbConnection);   //need this for number of pictureboxes to be generated via loop
            int m_numberOfPictures = 0;
            reader = sql_query.ExecuteReader();
            while(reader.Read())
            {
                m_numberOfPictures = Convert.ToInt32(reader["count(*)"]);                   //get number of pictures to be rendered, assign to a variable

            }

            reader.Dispose();

            PictureBox[] picturebox = new PictureBox[m_numberOfPictures];                   //create the array of PictureBox type
            int x = 0; int y = 0;                                                           // the coordinates

            for(i=0;i<m_numberOfPictures;i++)
            {
                x++;
                picturebox[i] = new PictureBox();
                this.Controls.Add(picturebox[i]);
                
                if(i%4 == 0 ){ x = 0; y = y + 110; }

                //picturebox[i].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                picturebox[i].Location = new Point(x * 75 + 10, y);
                
                picturebox[i].Size = new Size(75, 100);

                picturebox[i].SizeMode = PictureBoxSizeMode.Zoom;

                sql_query = new SQLiteCommand("select id,poster,rowid from tmp where rowid=" + (i + 1), m_dbConnection);
                //sql_query = new SQLiteCommand("select poster from tmp where rowid=" + (i+1), m_dbConnection);
                reader = sql_query.ExecuteReader();
                // **************try-catch block****************************
                try
                {
                    while (reader.Read())
                    {
                        if (reader["poster"]!= DBNull.Value)
                        {
                            byte[] a = (System.Byte[])reader["poster"];
                            picturebox[i].Image = IMDBUtilities.ByteToImage(a);
                        }
                        else { picturebox[i].ImageLocation = @"placeholder.png"; }
                    }
                    reader.Dispose();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "DB_ERROR");
                }
                // **************/try-catch block****************************
                picturebox[i].Name = "" + i;
                picturebox[i].Click += handleClick;
            }// end of for loop

            m_dbConnection.Close();

        }
//###########################################################################################################################################################################
        void handleClick(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            PictureBox picbox = sender as PictureBox;
            i = Convert.ToInt32(picbox.Name);
            //DEBUG : MessageBox.Show("clicked : " + picbox.Name);
            
            sql_query = new SQLiteCommand("select id,name,director,actor_main,actor_secondary,summary,poster,rowid from tmp a where rowid=" + (i+1),m_dbConnection);
            reader = sql_query.ExecuteReader();
            while (reader.Read())
            {
                m_richTextBox_details.Text = "";
                m_richTextBox_details.AppendText(reader["id"] + "\n" + reader["rowid"] + "\n" + reader["name"] + "\n" + reader["director"] + "\n" + reader["actor_main"] + "\n" + reader["actor_secondary"] + "\n" + reader["summary"] + "\n");
                movieID = Convert.ToInt32(reader["id"]); //glovar to track movie to edit

                if (reader["poster"] != DBNull.Value)
                {
                    byte[] a = (System.Byte[])reader["poster"];
                    m_picturebox_poster.Image = IMDBUtilities.ByteToImage(a);
                }
                else
                {
                    m_picturebox_poster.ImageLocation = @"placeholder.png";
                }
            }
            reader.Dispose();
            m_dbConnection.Close();
            //
            //MessageBox.Show("clicked : " + picbox.Name);
        }//end event
//###########################################################################################################################################################################
        private void m_button_newMovie_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Refresh();
            Form4_addMovie f4 = new Form4_addMovie(username);
            this.Close();
            f4.ShowDialog();
            
        }
//###########################################################################################################################################################################
        private void m_button_editMovie_Click(object sender, EventArgs e)
        {
            int id = movieID;
            if (id == 0)                                                //Hardcode : if id=0, no movie is currently selected, so throw up a messagebox
            {
                MessageBox.Show("No movie selected");
            }
            else
            {


                Form5_editMovie f5 = new Form5_editMovie(id, username);
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
        }
//###########################################################################################################################################################################
        private void m_button_logout_Click(object sender, EventArgs e)
        {
            //m_dbConnection.Open();
            using (SQLiteConnection con = new SQLiteConnection("Data Source=imdbclone.sqlite;Version=3;"))
            {


                con.Open();

                using (SQLiteCommand sql_delete = new SQLiteCommand("delete from cookie", con))
                {
                   sql_delete.ExecuteNonQuery();
                }


            }

            this.Hide();
            Form1_signin f1 = new Form1_signin();
            f1.ShowDialog();
            this.Close();

        }
//###########################################################################################################################################################################
        private void m_button_search_Click(object sender, EventArgs e)
        {
            
            searchstring = m_textbox_search.Text;
            searchByGenre = false;
            Form3_MovieList f3 = new Form3_MovieList(username, searchstring, searchByGenre);
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
//###########################################################################################################################################################################
    }
}
