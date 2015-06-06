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
//#####################################################################################################################################################################
    public partial class Form5_editMovie : Form
    {
        // GloVars                                                                          //GLOBAL VARIABLES, MAINLY SQLITE DATABASE ONES
        //
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=imdbclone.sqlite;Version=3;");
        SQLiteCommand sql_query;
        SQLiteDataReader reader;
        int i;
        //
        // /GloVars
//#####################################################################################################################################################################
        public Form5_editMovie()                                                            //DEFAULT CONSTRUCTOR
        {
            InitializeComponent();
        }
//#####################################################################################################################################################################   
        public Form5_editMovie(int id)                                                      //OVERLOADING CONSTRUCTOR TO RECEIVE IDENTIFIER OF 
                                                                                            //CURRENT ACTIVE RECORD FROM Form3
        {
            InitializeComponent();      
            
            i = id;
        }
//#####################################################################################################################################################################
        private void Form5_editMovie_Load(object sender, EventArgs e)                       //SINCE THIS IS EDITING, FILL UP FIELDS WITH DETAILS OF 
                                                                                            //CURRENTLY ACTIVE RECORD
        {
            m_dbConnection.Open();

            //sql_query = new SQLiteCommand("select name,director,actor_main,actor_secondary,summary,(select count(*) from movies b where b.id>=a.id) as Rid from movies a where Rid="+i,m_dbConnection);
            sql_query = new SQLiteCommand("select name,director,actor_main,actor_secondary,summary from movies where id=" + i, m_dbConnection);
            reader    = sql_query.ExecuteReader();

            while(reader.Read())
            {
                m_textBox_name.Text             = (reader["name"]               != DBNull.Value)?   Convert.ToString(reader["name"])            :"";
                m_textBox_director.Text         = (reader["director"]           != DBNull.Value)?   Convert.ToString(reader["director"])        :"";
                m_textBox_actorMain.Text        = (reader["actor_main"]         != DBNull.Value)?   Convert.ToString(reader["actor_main"])      :"";
                m_textBox_actorSecondary.Text   = (reader["actor_secondary"]    != DBNull.Value)?   Convert.ToString(reader["actor_secondary"]) :"";
                m_richTextBox_summary.Text      = (reader["summary"]            != DBNull.Value)?   Convert.ToString(reader["summary"])         :"";
                //m_pictureBox_poster goes here

            }

            m_dbConnection.Close();
        }
//#####################################################################################################################################################################
        private void m_button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_MovieList f3 = new Form3_MovieList();
            f3.ShowDialog();
            this.Close();
        }
//#####################################################################################################################################################################
    }
}
