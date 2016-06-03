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
                    isConnected = _database._connect("sql8.freemysqlhosting.net", "3306", "sql8120800", "wYrkTkd36M", "sql8120800");
                    lbl_db_connection_status.Text = "Connected";
                    lbl_db_connection_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
 
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
                    isConnected = _database._connect("sql8.freemysqlhosting.net", "3306", "sql8120800", "wYrkTkd36M", "sql8120800");
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

        private void btn_load_anime_series_Click(object sender, System.EventArgs e)
        {
            this.reload_connection();
            if(isConnected && !anime_loaded)
            {
                lsb_anime_info.Items.Clear();
                string show_all = "select * from sql8120800.anime_data";
                anime_loaded = _database.load_anime_from_database(lsb_anime_info, show_all);
            }
            else if(isConnected && anime_loaded)
            {
                MessageBox.Show("Anime already Loaded into ListBox!");
            }
        }
        
        private void btn_add_anime_series_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Not yet Implemented");
        }

        private void btn_show_unfinished_anime_series_Click(object sender  ,System.EventArgs e)
        {
            this.reload_connection();
            if(isConnected && !anime_loaded)
            {
                lsb_anime_info.Items.Clear();
                string show_unfinished = "select * from sql8120800.anime_data where anime_finished = 'NO'"; 
                anime_loaded = _database.load_anime_from_database(lsb_anime_info, show_unfinished);
            }
            else if(isConnected && anime_loaded)
            {
                lsb_anime_info.Items.Clear();
                string show_unfinished = "select * from sql8120800 where anime_unfinished = 'NO'"; 
                anime_loaded = _database.load_anime_from_database(lsb_anime_info, show_unfinished);
            }
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

