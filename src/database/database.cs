
/***********************************************
 * User inferface for the anime catalog program
 * designed from scratch
 * $AUTHOR: Jacob Powell
 * $DATE: 21/05/2016
 * *********************************************/

using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;

namespace anime_catalog_application
{
    public class Database
    {
        
        public string connection_string = "server=sql8.freemysqlhosting.net;port=3306;uid=sql8120800;pwd=wYrkTkd36M;database=sql8120800;";
        public MySqlDataReader database_reader;
        public MySqlConnection db_conn;

        public bool _connect(string server, string port, string uid, string pwd, string db_name)   
        {
            try
            {
                string connection_string = "server=" + server + ";port=" + port + ";uid=" + uid+";pwd="+pwd+";database="+db_name+";"; 
                db_conn = new MySqlConnection(connection_string);
                db_conn.Open();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
                return false;
            }
        }

        public bool _close()
        {
            try
            {
                db_conn.Close();
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " +ex.Message, "Error");
                return true;
            }
        }

        public bool load_database_into_listBox(System.Windows.Forms.ListBox lst_box)
        {
            string sql_show_all = "select * from sql8120800.anime_data";
            MySqlCommand show_all = new MySqlCommand(sql_show_all, db_conn); 

            try
            {
                database_reader = show_all.ExecuteReader();
                while(database_reader.Read()){ lst_box.Items.Add(database_reader["anime_name"]); }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Anime already Loaded into ListBox");
                return false;
            }
        }
    }
}


