
/***********************************************
 * Database Functionality for ListBox's
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
    public class DatabaseUtil
    {
        public bool load_anime_from_database(MySqlConnection db_conn, MySqlDataReader database_reader, System.Windows.Forms.ListBox lst_box, string sql_query)
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

        public List<string> load_anime_details(MySqlConnection db_conn, MySqlDataReader database_reader, List<string> anime_dt, string anime_id)
        {
            string sql_get_details = "select * from sql8120800.anime_data where anime_name = '" + anime_id + "'";
            MySqlCommand get_details = new MySqlCommand(sql_get_details, db_conn);
            try
            {
                database_reader = get_details.ExecuteReader();
                while(database_reader.Read())
                {
                    anime_dt.Add(database_reader["anime_name"].ToString());
                    anime_dt.Add(database_reader["anime_episode"].ToString());
                    anime_dt.Add(database_reader["anime_favourite"].ToString());
                    anime_dt.Add(database_reader["anime_finished"].ToString());
                }
                return anime_dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return anime_dt;
            }
        }

        public void add_anime_series(MySqlConnection db_conn, MySqlDataReader database_reader, string anime_name, string anime_episode, string anime_epiosde)
        {
            string sql_query_add = "";
        }
    }
}
