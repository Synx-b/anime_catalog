
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

        public bool _connect()
        {
            try
            {
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


        public bool load_anime_from_database(System.Windows.Forms.ListBox lst_box, string sql_query)
        {
            MySqlCommand show_all = new MySqlCommand(sql_query, db_conn);

            try
            {
                database_reader = show_all.ExecuteReader();
                while(database_reader.Read()){ lst_box.Items.Add(database_reader["anime_name"]); }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public void load_anime_details(string anime_id)
        {
        }
    }
}
