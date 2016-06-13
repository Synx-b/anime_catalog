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

namespace anime_catalog_application
{
    public partial class MainWindow : Form
    {
        // Private Class Members
        private Database _database = new Database();
        private bool isConnected = false;
        private bool anime_loaded = false;
        private string query_show_all = "select * from sql8120800.anime_data";
        private string query_show_unfinished = "select * from sql8120800.anime_data where anime_finished = 'NO'";
        private const int SORT_ALPH = 1;
        private const int SORT_OLD_NEW = 2;
        private const int SORT_NEW_OLD = 3;

        // Class Contructor
        public MainWindow()
        {
            InitializeComponent();
        }

        // Class Methods
        private void quick_connect()
        {
            if(!isConnected)
            {
                try
                {
                    isConnected = _database._connect();
                    if(isConnected)
                    {
                        lbl_db_connection_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                        lbl_db_connection_status.Text = "Connected";
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void reload_connection()
        {
            if(isConnected)
            {
                try
                {
                    isConnected = _database._close();
                    isConnected = _database._connect();
                    anime_loaded = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(!isConnected)
            {
                MessageBox.Show("No Connection To Database");
            }
        }

        private void show_anime_details()
        {
            string anime_name = "hello";
            AnimeDetails _ad = new AnimeDetails(anime_name);
            _ad.ShowDialog();
            /*
            if(!anime_loaded)
            {
                MessageBox.Show("Anime not Loaded!");
            }
            else
            {
                try
                {
                    string anime_name = lsb_anime_info.SelectedItem.ToString();
                    AnimeDetails _ad = new AnimeDetails(anime_name);
                    _ad.ShowDialog();
                }
                catch(System.NullReferenceException)
                {
                    MessageBox.Show("No Anime Series Selected");
                }
            }*/
        }

        private void load_all_anime()
        {
            this.reload_connection();
            if(isConnected && !anime_loaded)
            {
                lsb_anime_info.Items.Clear();
                anime_loaded = _database.load_anime_from_database(lsb_anime_info, this.query_show_all);
            }
            else if(isConnected && anime_loaded)
            {
                MessageBox.Show("Anime already Loaded into ListBox!");
            }

        }

        private void load_unfinished_anime()
        {
            this.reload_connection();
            if(isConnected && !anime_loaded)
            {
                lsb_anime_info.Items.Clear();
                anime_loaded = _database.load_anime_from_database(lsb_anime_info, this.query_show_unfinished);
            }
            else if(isConnected && anime_loaded)
            {
                lsb_anime_info.Items.Clear();
                anime_loaded = _database.load_anime_from_database(lsb_anime_info, this.query_show_unfinished);
            }

        }

        private void sort_anime(System.Windows.Forms.ListBox lsb, int sort_ID)
        {
            if(lsb.Items.Count > 49)
            {
               switch(sort_ID)
               {
                    case SORT_ALPH:
                        lsb.Sorted = true;
                        this.reload_connection();
                        this.load_all_anime();
                        break;
                    case SORT_OLD_NEW:
                        lsb.Sorted = false;
                        this.reload_connection();
                        this.load_all_anime();
                        break;
               }
            }
            else
            {
                switch(sort_ID)
                {
                    case SORT_ALPH:
                        lsb.Sorted = true;
                        this.reload_connection();
                        this.load_unfinished_anime();
                        break;
                    case SORT_OLD_NEW:
                        lsb.Sorted = false;
                        this.reload_connection();
                        this.load_unfinished_anime();
                        break;
                }
            }
        }

        // Window Widget Methods

        private void file_close_window(object sender, System.EventArgs e)
        {
            // Close the Window
            base.Close();
        }

        private void database_connectionOpenToolStripItem_Click(object sender, System.EventArgs e)
        {
           this.quick_connect();
        }

        private void database_connectionCloseToolStripItem_Click(object sender, System.EventArgs e)
        {
            if(!isConnected)
            {
                MessageBox.Show("Not Connected to Database");
            }
            else
            {
                isConnected = _database._close();
                if(lsb_anime_info.Items.Count > 0)
                {
                    lsb_anime_info.Items.Clear();
                    anime_loaded = false;
                }
                lbl_db_connection_status.Text = "No Connection";
                lbl_db_connection_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        private void anime_detailsToolStripItem_Click(object sender, System.EventArgs e)
        {
            this.show_anime_details();
        }

        private void anime_sort_watched_old_new_ToolStripItem_Click(object sender, System.EventArgs e)
        {
            if(anime_loaded)
            {
                this.sort_anime(this.lsb_anime_info, SORT_OLD_NEW);
            }
            else
            {
                MessageBox.Show("Anime not Loaded");
            }
        }

        private void anime_sort_alph_ToolStripItem_Click(object sender, System.EventArgs e)
        {
            if(anime_loaded)
            {
                this.sort_anime(this.lsb_anime_info, SORT_ALPH);
            }
            else
            {
                MessageBox.Show("Anime not Loaded");
            }
        }

        private void btn_load_anime_series_Click(object sender, System.EventArgs e)
        {
            this.load_all_anime();
        }

        private void btn_open_connection_database_Click(object sender, System.EventArgs e)
        {
            this.quick_connect();
        }

        private void btn_add_anime_series_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Not yet Implemented");
        }

        private void btn_show_unfinished_anime_series_Click(object sender, System.EventArgs e)
        {
            this.load_unfinished_anime();
        }

        private void btn_show_anime_details_Click(object sender, System.EventArgs e)
        {
            this.show_anime_details();
        }

        private void btn_exit_Click(object sender, System.EventArgs e)
        {
            base.Close();
        }
    }
}
