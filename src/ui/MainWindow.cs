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


        // Window Widget Methods
        
        private void file_close_window(object sender, System.EventArgs e)
        {
            // Close the Window
            base.Close();
        }

        private void database_connectionOpenToolStripItem_Click(object sender, System.EventArgs e)
        {
            if(!isConnected)
            {
                try
                {
                    isConnected = _database._connect("sql8.freemysqlhosting.net", "3306", "sql8120800", "wYrkTkd36M", "sql8120800");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
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
            }
        }

        private void btn_load_anime_series_Click(object sender, System.EventArgs e)
        {
            if(isConnected && !anime_loaded)
            {
                lsb_anime_info.Items.Clear();
                anime_loaded = _database.load_database_into_listBox(lsb_anime_info);
            }
            else if(!isConnected)
            {
                MessageBox.Show("No Connection To Dataabase");
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
            MessageBox.Show("Not yet Implemented");
        }
    } 
}

