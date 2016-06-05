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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lbl_title = new System.Windows.Forms.Label();        
            this.lbl_db_connection_info = new System.Windows.Forms.Label();
            this.lbl_db_connection_status = new System.Windows.Forms.Label();
            this.lsb_anime_info = new System.Windows.Forms.ListBox();
            this.btn_load_anime_series = new System.Windows.Forms.Button();
            this.btn_add_anime_series = new System.Windows.Forms.Button();
            this.btn_show_unfinished_anime_series = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_show_anime_details = new System.Windows.Forms.Button();
            this.btn_open_connection_database = new System.Windows.Forms.Button();
            this.main_menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.database_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.database_connectionToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.database_connectionOpenToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.database_connectionCloseToolStripItem = new System.Windows.Forms.ToolStripMenuItem(); 
            this.anime_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anime_detailsToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anime_sortToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anime_sort_alph_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anime_sort_watched_old_new_ToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu_strip.SuspendLayout();
            this.SuspendLayout();

            // Main Window Strip
            this.main_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{
                    this.fileToolStripMenuItem,
                    this.database_ToolStripItem,
                    this.anime_ToolStripItem});
            this.main_menu_strip.Location = new System.Drawing.Point(0,0);
            this.main_menu_strip.Name = "Main Menu Strip";
            this.main_menu_strip.Size = new System.Drawing.Size(400, 20);
            this.main_menu_strip.TabIndex = 15;
            this.main_menu_strip.Text = "MainMenuStrip";

            // File Menu Strip Item
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{
                    this.file_closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "File Strip Menu Item";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";

            // File_Close Menu Item
            this.file_closeToolStripMenuItem.Name = "Close(File), Menu Item";
            this.file_closeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.file_closeToolStripMenuItem.Text = "Close";
            this.file_closeToolStripMenuItem.Click += new System.EventHandler(this.file_close_window);


            // Database Menu Strip Item
            this.database_ToolStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    this.database_connectionToolStripItem});
            this.database_ToolStripItem.Name = "Database Strip Menu Item";
            this.database_ToolStripItem.Size = new System.Drawing.Size(70, 40);
            this.database_ToolStripItem.Text = "Database";

             // Database_Connection Menu Item
            this.database_connectionToolStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{
                this.database_connectionOpenToolStripItem,
                this.database_connectionCloseToolStripItem});
            this.database_connectionToolStripItem.Name = "Connection(Database)";
            this.database_connectionToolStripItem.Size = new System.Drawing.Size(150, 22);
            this.database_connectionToolStripItem.Text = "Connections";
            
            // Open connection to the databse Menu Item
            this.database_connectionOpenToolStripItem.Name = "Open Connection To Database";
            this.database_connectionOpenToolStripItem.Size = new System.Drawing.Size(150, 22);
            this.database_connectionOpenToolStripItem.Text = "Open";
            this.database_connectionOpenToolStripItem.Click += new System.EventHandler(this.database_connectionOpenToolStripItem_Click);

            // Close the Current connection Menu Item
            this.database_connectionCloseToolStripItem.Name = "Close Connection To Database";
            this.database_connectionCloseToolStripItem.Size = new System.Drawing.Size(150, 22);
            this.database_connectionCloseToolStripItem.Text = "Close";
            this.database_connectionCloseToolStripItem.Click += new System.EventHandler(this.database_connectionCloseToolStripItem_Click);

            // Anime Menu Strip Item
            this.anime_ToolStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{
                    this.anime_detailsToolStripItem,
                    this.anime_sortToolStripItem});
            this.anime_ToolStripItem.Name = "Anime Strip Menu Item";
            this.anime_ToolStripItem.Size = new System.Drawing.Size(105, 60);
            this.anime_ToolStripItem.Text = "Anime";
            
            // Anime Details Menu Strip Item
            this.anime_detailsToolStripItem.Name = "Show Details of the Selected Anime Series";
            this.anime_detailsToolStripItem.Size = new System.Drawing.Size(150, 20);
            this.anime_detailsToolStripItem.Text = "Show Details";
            this.anime_detailsToolStripItem.Click += new System.EventHandler(this.anime_detailsToolStripItem_Click);

            // Anime Sort Options Menu Strip Item
            this.anime_sortToolStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{
                    this.anime_sort_alph_ToolStripItem,
                    this.anime_sort_watched_old_new_ToolStripItem});
            this.anime_sortToolStripItem.Name = "Sorting options for the Displayed Anime";
            this.anime_sortToolStripItem.Text = "Sort Options";
            this.anime_sortToolStripItem.Size = new System.Drawing.Size(150, 20);
            
            // Anime Sort by Alph Menu Strip Item
            this.anime_sort_alph_ToolStripItem.Name = "Sort Anime by Aplh";
            this.anime_sort_alph_ToolStripItem.Size = new System.Drawing.Size(150, 20);
            this.anime_sort_alph_ToolStripItem.Text = "Alphabetical";
            this.anime_sort_alph_ToolStripItem.Click += new System.EventHandler(this.anime_sort_alph_ToolStripItem_Click);

            // Anime Sort by order Watched, Oldest to Newest
            this.anime_sort_watched_old_new_ToolStripItem.Name = "Sort Anime by order they were watched in, Oldest to newest";
            this.anime_sort_watched_old_new_ToolStripItem.Size = new System.Drawing.Size(150, 20);
            this.anime_sort_watched_old_new_ToolStripItem.Text = "Oldest -> Newest";
            this.anime_sort_watched_old_new_ToolStripItem.Click += new System.EventHandler(this.anime_sort_watched_old_new_ToolStripItem_Click);
                    
           
            // Window Title 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(9, 25);
            this.lbl_title.Name = "MainWindow Title"; 
            this.lbl_title.Size = new System.Drawing.Size(150, 21);
            this.lbl_title.Text = "Anime Catalog";

            
            // Button to lead contents of database into list box
            this.btn_load_anime_series.AutoSize = true;
            this.btn_load_anime_series.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_anime_series.Location = new System.Drawing.Point(412, 45); 
            this.btn_load_anime_series.Name = "Button For Loading Contents Into ListBox";
            this.btn_load_anime_series.Text = "Load Anime";
            this.btn_load_anime_series.Size = new System.Drawing.Size(160, 20);
            this.btn_load_anime_series.Click += new System.EventHandler(this.btn_load_anime_series_Click);

            // Button to add an anime series to the database
            this.btn_add_anime_series.AutoSize = true;
            this.btn_add_anime_series.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
            this.btn_add_anime_series.Location = new System.Drawing.Point(412, 75);
            this.btn_add_anime_series.Name = "Button to add a new anime series into the database";
            this.btn_add_anime_series.Text = "Add Anime Series";
            this.btn_add_anime_series.Size = new System.Drawing.Size(160, 20);
            this.btn_add_anime_series.Click += new System.EventHandler(this.btn_add_anime_series_Click);

            // Button to only show Anime that have not been finished yet
            this.btn_show_unfinished_anime_series.AutoSize = true;
            this.btn_show_unfinished_anime_series.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_unfinished_anime_series.Size = new System.Drawing.Size(160, 20);
            this.btn_show_unfinished_anime_series.Location = new System.Drawing.Point(412, 105);
            this.btn_show_unfinished_anime_series.Name = "Button to only show the Anime in the database that have not been Finished";
            this.btn_show_unfinished_anime_series.Text = "Show Unfinished";
            this.btn_show_unfinished_anime_series.Click += new System.EventHandler(this.btn_show_unfinished_anime_series_Click);

            // Button to Show the details of the Anime Selected
            this.btn_show_anime_details.AutoSize = true;
            this.btn_show_anime_details.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_anime_details.Size = new System.Drawing.Size(160, 20);
            this.btn_show_anime_details.Location = new System.Drawing.Point(412, 135);
            this.btn_show_anime_details.Name = "Button to Show details of Selected Anime Series";
            this.btn_show_anime_details.Text = "Show Details";
            this.btn_show_anime_details.Click += new System.EventHandler(this.btn_show_anime_details_Click);

            // Button to Exit the Form
            this.btn_exit.AutoSize = true;
            this.btn_exit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Size = new System.Drawing.Size(160, 20);
            this.btn_exit.Location = new System.Drawing.Point(580, 45);
            this.btn_exit.Name = "Button to Exit the Form";
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);

            // Button to Connect to the Database
            this.btn_open_connection_database.AutoSize = true;
            this.btn_open_connection_database.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_connection_database.Location = new System.Drawing.Point(580, 75);
            this.btn_open_connection_database.Size = new System.Drawing.Size(160, 20);
            this.btn_open_connection_database.Name = "Button to Open the Connection to the Database";
            this.btn_open_connection_database.Text = "Open Connection";
            this.btn_open_connection_database.Click += new System.EventHandler(this.btn_open_connection_database_Click); 
            

            // Database Connection Info
            this.lbl_db_connection_info.AutoSize = true;
            this.lbl_db_connection_info.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_db_connection_info.Location = new System.Drawing.Point(150, 25);
            this.lbl_db_connection_info.Name = "Database Connection Info";
            this.lbl_db_connection_info.Size = new System.Drawing.Size(50, 21);
            this.lbl_db_connection_info.Text = "Connection To Database: ";

            // Database Connection Status
            this.lbl_db_connection_status.AutoSize = true;
            this.lbl_db_connection_status.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_db_connection_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_db_connection_status.Location = new System.Drawing.Point(340, 25);
            this.lbl_db_connection_status.Name = "Database Connection Status";
            this.lbl_db_connection_status.Size = new System.Drawing.Size(50, 21);
            this.lbl_db_connection_status.Text = "Not Connected";

            // Text Box which all the information about the anime I have watched will be stored
            this.lsb_anime_info.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_anime_info.FormattingEnabled = true;
            this.lsb_anime_info.ItemHeight = 20;
            this.lsb_anime_info.Location = new System.Drawing.Point(9, 45);
            this.lsb_anime_info.Name = "Anime Information Box";
            this.lsb_anime_info.Size = new System.Drawing.Size(400, 500);
            this.lsb_anime_info.TabIndex = 5; 
            this.lsb_anime_info.Sorted = true;

            // MainWindow
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_db_connection_info);
            this.Controls.Add(this.lbl_db_connection_status);
            this.Controls.Add(this.lsb_anime_info);
            this.Controls.Add(this.btn_load_anime_series);
            this.Controls.Add(this.btn_add_anime_series);
            this.Controls.Add(this.btn_show_unfinished_anime_series);
            this.Controls.Add(this.btn_show_anime_details);
            this.Controls.Add(this.btn_open_connection_database);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.main_menu_strip);
            this.MainMenuStrip = this.main_menu_strip;
            this.Name = "MainWindow";
            this.Text = "Anime Catalog";
            this.main_menu_strip.ResumeLayout(false);
            this.main_menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        
        }

        // Window Widget Declarations
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_db_connection_info;
        private System.Windows.Forms.Label lbl_db_connection_status;
        private System.Windows.Forms.ListBox lsb_anime_info;
        private System.Windows.Forms.MenuStrip main_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem database_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem database_connectionToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem database_connectionOpenToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem database_connectionCloseToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem anime_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem anime_detailsToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem anime_sortToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem anime_sort_watched_old_new_ToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem anime_sort_alph_ToolStripItem;
        private System.Windows.Forms.Button btn_load_anime_series;
        private System.Windows.Forms.Button btn_add_anime_series;
        private System.Windows.Forms.Button btn_show_unfinished_anime_series;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_show_anime_details;
        private System.Windows.Forms.Button btn_open_connection_database;
    }
}
