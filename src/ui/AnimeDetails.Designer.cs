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
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
  

        private void InitializeComponent()
        {
            this.lbl_anime_name = new System.Windows.Forms.Label();
            this.lbl_anime_episode = new System.Windows.Forms.Label();
            this.lbl_anime_favourite = new System.Windows.Forms.Label();
            this.lbl_anime_finished = new System.Windows.Forms.Label();
            this.lbl_anime_name_dep = new System.Windows.Forms.Label();
            this.lbl_anime_episode_dep = new System.Windows.Forms.Label();
            this.lbl_anime_favourite_dep = new System.Windows.Forms.Label();
            this.lbl_anime_finished_dep = new System.Windows.Forms.Label();
            this.lbl_anime_details_title = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_edit_anime_details = new System.Windows.Forms.Button();

            // Code in the Configs for the Labels
            this.lbl_anime_details_title.AutoSize = true;
            this.lbl_anime_details_title.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anime_details_title.Name = "Anime Details Title Label";
            this.lbl_anime_details_title.Text = "Anime Details";
            this.lbl_anime_details_title.Location = new System.Drawing.Point(9, 10);
            this.lbl_anime_details_title.Size = new System.Drawing.Size(50, 20);

            this.lbl_anime_name.AutoSize = true;
            this.lbl_anime_name.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anime_name.Text = "Anime Name: ";
            this.lbl_anime_name.Name = "Anime Name Label";
            this.lbl_anime_name.Location = new System.Drawing.Point(9, 50);
            this.lbl_anime_name.Size = new System.Drawing.Size(50, 20);

            this.lbl_anime_episode.AutoSize = true;
            this.lbl_anime_episode.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anime_episode.Text = "Anime Episode: ";
            this.lbl_anime_episode.Name = "Current Anime Episode Label";
            this.lbl_anime_episode.Location = new System.Drawing.Point(9, 70);
            this.lbl_anime_episode.Size = new System.Drawing.Size(50, 20);

            this.lbl_anime_favourite.AutoSize = true;
            this.lbl_anime_favourite.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anime_favourite.Text = "Anime Favourite: ";
            this.lbl_anime_favourite.Name = "Whether or not the Anime is listed as a favouritet";
            this.lbl_anime_favourite.Location = new System.Drawing.Point(9, 90);
            this.lbl_anime_favourite.Size = new System.Drawing.Size(50, 20);

            this.lbl_anime_finished.AutoSize = true;
            this.lbl_anime_finished.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anime_finished.Name = "Whether or not the anime is listed as finished";
            this.lbl_anime_finished.Text = "Anime Finished: ";
            this.lbl_anime_finished.Location = new System.Drawing.Point(9, 110);
            this.lbl_anime_finished.Size = new System.Drawing.Size(50, 20);
            

            // Code to control the GUI
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lbl_anime_details_title);
            this.Controls.Add(this.lbl_anime_name);
            this.Controls.Add(this.lbl_anime_episode);
            this.Controls.Add(this.lbl_anime_favourite);
            this.Controls.Add(this.lbl_anime_finished);
            this.Name = "Anime Details Loaded From Database";
            this.Text = "View Anime Details";
            this.ResumeLayout(false);
            this.PerformLayout(); 
        }

        private System.Windows.Forms.Label lbl_anime_details_title;
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
