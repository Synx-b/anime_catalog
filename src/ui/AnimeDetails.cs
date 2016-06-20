/***********************************************
 * UI to Edit and View the Details of the
 * selected anime series from the database
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
    public partial class AnimeDetails : Form
    {
        private string anime_id;
        private DatabaseCore _database_core = new DatabaseCore();
        private DatabaseUtil _database_util = new DatabaseUtil();
        private List<string> anime_details = new List<string>();
        private bool conn = false;

        public AnimeDetails(string anime_name)
        {
            this.anime_id = anime_name;
            InitializeComponent();
            load_anime_details(this.anime_id);
        }

        private void load_anime_details(string anime_id)
        {
            try
            {
                conn = _database_core._connect();
                anime_details = _database_util.load_anime_details(_database_core.db_conn, _database_core.database_reader,anime_details, anime_id);

                // Add the Anime Details
                lbl_anime_name_dep.Text = anime_details[0];
                lbl_anime_episode_dep.Text = anime_details[1];
                lbl_anime_favourite_dep.Text = anime_details[2];
                lbl_anime_finished_dep.Text = anime_details[3];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
