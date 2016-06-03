/***********************************************
 * UI to show the details of the individual
 * anime series from the database 
 *
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
        private void InitializeComponent()
        {
            // Code Window Widgets here
        }

        private System.Windows.Forms.Label lbl_anime_name;
        private System.Windows.Forms.Label lbl_anime_episode;
        private System.Windows.Forms.Label lbl_anime_favourite;
        private System.Windows.Forms.Label lbl_anime_finished;
        private System.Windows.Forms.Label lbl_anime_name_dep;
        private System.Windows.Forms.Label lbl_anime_episode_dep;
        private System.Windows.Forms.Label lbl_anime_favourite_dep;
        private System.Windows.Forms.Label lbl_anime_finished_dep;
        private System.Windows.Forms.Button btn_edit_anime_details;
        private System.Windows.Forms.Button btn_exit;
        
    }
}
