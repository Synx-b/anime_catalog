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

namespace anime_catalog_application
{
    public partial class AnimeDetails : Form
    {
        string anime_id;
        Database _database = new Database();

        public AnimeDetails(string anime_name)
        {
            this.anime_id = anime_name;
            InitializeComponent();
            load_anime_details(this.anime_id);
        }

        private void load_anime_details(string anime_id)
        {
        }
    }
}
