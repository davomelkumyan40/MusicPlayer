using Music_Player.Components.Custom_Controls;

namespace Music_Player
{
    partial class Player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.close_btn = new System.Windows.Forms.Button();
            this.menu_bar = new System.Windows.Forms.Panel();
            this.search_box_wrapper = new System.Windows.Forms.Panel();
            this.search_box = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.Panel();
            this.download_btn = new System.Windows.Forms.Button();
            this.menu_line = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.userPicture = new Music_Player.Components.Custom_Controls.CirclePicturBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.light_panel = new System.Windows.Forms.Panel();
            this.plus_btn = new System.Windows.Forms.Button();
            this.playlists = new System.Windows.Forms.Button();
            this.now_playing = new System.Windows.Forms.Button();
            this.recent_plays = new System.Windows.Forms.Button();
            this.my_music = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.PictureBox();
            this.menu_btn = new System.Windows.Forms.PictureBox();
            this.general_panel2 = new System.Windows.Forms.Panel();
            this.text_player = new System.Windows.Forms.Label();
            this.music_Track_Bar = new MB.Controls.ColorSlider();
            this.notify_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.general_panel = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.maximize_btn = new System.Windows.Forms.Button();
            this.music_list_panel = new System.Windows.Forms.Panel();
            this.about_btn = new System.Windows.Forms.Button();
            this.playing_btn = new System.Windows.Forms.Button();
            this.songs_btn = new System.Windows.Forms.Button();
            this.scroll_close_panel = new System.Windows.Forms.Panel();
            this.music_list = new System.Windows.Forms.FlowLayoutPanel();
            this.light_panel2 = new System.Windows.Forms.Panel();
            this.line_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_btn_general = new System.Windows.Forms.Label();
            this.music_control_panel = new System.Windows.Forms.Panel();
            this.volume_btn = new Music_Player.Components.Custom_Controls.Circle_Button();
            this.music_progress_total_time = new System.Windows.Forms.Label();
            this.music_progress_time = new System.Windows.Forms.Label();
            this.random_play_btn = new Music_Player.Components.Custom_Controls.Circle_Button();
            this.replay_btn = new Music_Player.Components.Custom_Controls.Circle_Button();
            this.volume_bar = new EConTech.Windows.MUSICUI.MusicTrackBar();
            this.right_arrow_btn = new Music_Player.Components.Custom_Controls.Circle_Button();
            this.left_arrow_btn = new Music_Player.Components.Custom_Controls.Circle_Button();
            this.play_btn = new Music_Player.Components.Custom_Controls.Circle_Button();
            this.player_refresher = new System.Windows.Forms.Timer(this.components);
            this.file_open = new System.Windows.Forms.OpenFileDialog();
            this.menu_bar.SuspendLayout();
            this.search_box_wrapper.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
            this.general_panel2.SuspendLayout();
            this.general_panel.SuspendLayout();
            this.music_list_panel.SuspendLayout();
            this.music_control_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(816, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(59, 48);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.close_btn.MouseEnter += new System.EventHandler(this.Close_btn_MouseEnter);
            this.close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            // 
            // menu_bar
            // 
            this.menu_bar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menu_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.menu_bar.Controls.Add(this.search_box_wrapper);
            this.menu_bar.Controls.Add(this.menu);
            this.menu_bar.Controls.Add(this.search_btn);
            this.menu_bar.Controls.Add(this.menu_btn);
            this.menu_bar.Controls.Add(this.general_panel2);
            this.menu_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_bar.Location = new System.Drawing.Point(0, 0);
            this.menu_bar.Margin = new System.Windows.Forms.Padding(0);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.Size = new System.Drawing.Size(325, 920);
            this.menu_bar.TabIndex = 0;
            this.menu_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            // 
            // search_box_wrapper
            // 
            this.search_box_wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.search_box_wrapper.Controls.Add(this.search_box);
            this.search_box_wrapper.Location = new System.Drawing.Point(12, 94);
            this.search_box_wrapper.Name = "search_box_wrapper";
            this.search_box_wrapper.Size = new System.Drawing.Size(249, 34);
            this.search_box_wrapper.TabIndex = 6;
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.search_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.ForeColor = System.Drawing.Color.White;
            this.search_box.Location = new System.Drawing.Point(9, 8);
            this.search_box.Margin = new System.Windows.Forms.Padding(0);
            this.search_box.MaxLength = 20;
            this.search_box.Multiline = false;
            this.search_box.Name = "search_box";
            this.search_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.search_box.ShowSelectionMargin = true;
            this.search_box.Size = new System.Drawing.Size(239, 26);
            this.search_box.TabIndex = 3;
            this.search_box.Text = "  Search";
            this.search_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Search_box_MouseDown);
            // 
            // menu
            // 
            this.menu.Controls.Add(this.download_btn);
            this.menu.Controls.Add(this.menu_line);
            this.menu.Controls.Add(this.logout_btn);
            this.menu.Controls.Add(this.userPicture);
            this.menu.Controls.Add(this.login_btn);
            this.menu.Controls.Add(this.light_panel);
            this.menu.Controls.Add(this.plus_btn);
            this.menu.Controls.Add(this.playlists);
            this.menu.Controls.Add(this.now_playing);
            this.menu.Controls.Add(this.recent_plays);
            this.menu.Controls.Add(this.my_music);
            this.menu.Location = new System.Drawing.Point(0, 145);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(325, 602);
            this.menu.TabIndex = 5;
            // 
            // download_btn
            // 
            this.download_btn.BackColor = System.Drawing.Color.Transparent;
            this.download_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download_btn.FlatAppearance.BorderSize = 0;
            this.download_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_btn.ForeColor = System.Drawing.Color.White;
            this.download_btn.Image = global::Music_Player.Properties.Resources.download_32;
            this.download_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.download_btn.Location = new System.Drawing.Point(12, 218);
            this.download_btn.Margin = new System.Windows.Forms.Padding(0);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(313, 53);
            this.download_btn.TabIndex = 13;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = false;
            this.download_btn.Click += new System.EventHandler(this.Download_btn_Click);
            this.download_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.download_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.download_btn.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.download_btn.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // menu_line
            // 
            this.menu_line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.menu_line.Location = new System.Drawing.Point(26, 283);
            this.menu_line.Name = "menu_line";
            this.menu_line.Size = new System.Drawing.Size(280, 2);
            this.menu_line.TabIndex = 7;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::Music_Player.Properties.Resources.logout;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(12, 352);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(0);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(313, 53);
            this.logout_btn.TabIndex = 12;
            this.logout_btn.Text = "Log  Out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Visible = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            this.logout_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.logout_btn.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.logout_btn.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.userPicture.Enabled = false;
            this.userPicture.Location = new System.Drawing.Point(12, 0);
            this.userPicture.Margin = new System.Windows.Forms.Padding(0);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(50, 50);
            this.userPicture.TabIndex = 11;
            this.userPicture.TabStop = false;
            this.userPicture.Visible = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Image = ((System.Drawing.Image)(resources.GetObject("login_btn.Image")));
            this.login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_btn.Location = new System.Drawing.Point(12, 0);
            this.login_btn.Margin = new System.Windows.Forms.Padding(0);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(313, 53);
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "Sign  In";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            this.login_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.login_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.login_btn.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.login_btn.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // light_panel
            // 
            this.light_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.light_panel.Location = new System.Drawing.Point(3, 0);
            this.light_panel.Name = "light_panel";
            this.light_panel.Size = new System.Drawing.Size(10, 53);
            this.light_panel.TabIndex = 3;
            // 
            // plus_btn
            // 
            this.plus_btn.BackColor = System.Drawing.Color.Transparent;
            this.plus_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_btn.FlatAppearance.BorderSize = 0;
            this.plus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_btn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_btn.ForeColor = System.Drawing.Color.White;
            this.plus_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plus_btn.Location = new System.Drawing.Point(271, 298);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(53, 53);
            this.plus_btn.TabIndex = 9;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = false;
            this.plus_btn.Click += new System.EventHandler(this.Plus_btn_Click);
            this.plus_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.plus_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.plus_btn.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.plus_btn.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // playlists
            // 
            this.playlists.BackColor = System.Drawing.Color.Transparent;
            this.playlists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlists.FlatAppearance.BorderSize = 0;
            this.playlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlists.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlists.ForeColor = System.Drawing.Color.White;
            this.playlists.Image = global::Music_Player.Properties.Resources.view_details_32;
            this.playlists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playlists.Location = new System.Drawing.Point(12, 299);
            this.playlists.Name = "playlists";
            this.playlists.Size = new System.Drawing.Size(260, 53);
            this.playlists.TabIndex = 8;
            this.playlists.Text = "      Play lists";
            this.playlists.UseVisualStyleBackColor = false;
            this.playlists.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.playlists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.playlists.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.playlists.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // now_playing
            // 
            this.now_playing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.now_playing.BackColor = System.Drawing.Color.Transparent;
            this.now_playing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.now_playing.FlatAppearance.BorderSize = 0;
            this.now_playing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.now_playing.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.now_playing.ForeColor = System.Drawing.Color.White;
            this.now_playing.Image = global::Music_Player.Properties.Resources.treble_clef_32;
            this.now_playing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.now_playing.Location = new System.Drawing.Point(12, 162);
            this.now_playing.Name = "now_playing";
            this.now_playing.Size = new System.Drawing.Size(313, 53);
            this.now_playing.TabIndex = 7;
            this.now_playing.Text = "    Now playing";
            this.now_playing.UseVisualStyleBackColor = false;
            this.now_playing.Click += new System.EventHandler(this.Now_playing_Click);
            this.now_playing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.now_playing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.now_playing.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.now_playing.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // recent_plays
            // 
            this.recent_plays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recent_plays.BackColor = System.Drawing.Color.Transparent;
            this.recent_plays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recent_plays.FlatAppearance.BorderSize = 0;
            this.recent_plays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recent_plays.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recent_plays.ForeColor = System.Drawing.Color.White;
            this.recent_plays.Image = global::Music_Player.Properties.Resources.time_8_32;
            this.recent_plays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recent_plays.Location = new System.Drawing.Point(12, 109);
            this.recent_plays.Name = "recent_plays";
            this.recent_plays.Size = new System.Drawing.Size(313, 53);
            this.recent_plays.TabIndex = 6;
            this.recent_plays.Text = "     Recent plays";
            this.recent_plays.UseVisualStyleBackColor = false;
            this.recent_plays.Click += new System.EventHandler(this.Recent_plays_Click);
            this.recent_plays.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.recent_plays.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.recent_plays.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.recent_plays.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // my_music
            // 
            this.my_music.BackColor = System.Drawing.Color.Transparent;
            this.my_music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.my_music.FlatAppearance.BorderSize = 0;
            this.my_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_music.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_music.ForeColor = System.Drawing.Color.White;
            this.my_music.Image = global::Music_Player.Properties.Resources.note_32;
            this.my_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.my_music.Location = new System.Drawing.Point(12, 56);
            this.my_music.Margin = new System.Windows.Forms.Padding(0);
            this.my_music.Name = "my_music";
            this.my_music.Size = new System.Drawing.Size(313, 53);
            this.my_music.TabIndex = 5;
            this.my_music.Text = " My music";
            this.my_music.UseVisualStyleBackColor = false;
            this.my_music.Click += new System.EventHandler(this.My_music_Click);
            this.my_music.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.my_music.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.my_music.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.my_music.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Image = global::Music_Player.Properties.Resources.search_white;
            this.search_btn.Location = new System.Drawing.Point(260, 94);
            this.search_btn.Margin = new System.Windows.Forms.Padding(0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(62, 34);
            this.search_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_btn.TabIndex = 4;
            this.search_btn.TabStop = false;
            this.search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            this.search_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.search_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.search_btn.MouseEnter += new System.EventHandler(this.Search_btn_MouseEnter);
            this.search_btn.MouseLeave += new System.EventHandler(this.Search_btn_MouseLeave);
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.Transparent;
            this.menu_btn.Image = global::Music_Player.Properties.Resources.menu;
            this.menu_btn.Location = new System.Drawing.Point(0, 34);
            this.menu_btn.Margin = new System.Windows.Forms.Padding(0);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(62, 48);
            this.menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_btn.TabIndex = 2;
            this.menu_btn.TabStop = false;
            this.menu_btn.Click += new System.EventHandler(this.Menu_btn_Click);
            this.menu_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.menu_btn.MouseEnter += new System.EventHandler(this.Menu_btn_MouseEnter);
            this.menu_btn.MouseLeave += new System.EventHandler(this.Menu_btn_MouseLeave);
            // 
            // general_panel2
            // 
            this.general_panel2.BackColor = System.Drawing.Color.Transparent;
            this.general_panel2.Controls.Add(this.text_player);
            this.general_panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.general_panel2.Location = new System.Drawing.Point(0, 0);
            this.general_panel2.Name = "general_panel2";
            this.general_panel2.Size = new System.Drawing.Size(325, 48);
            this.general_panel2.TabIndex = 1;
            this.general_panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseDown);
            this.general_panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseMove);
            this.general_panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseUp);
            // 
            // text_player
            // 
            this.text_player.AutoSize = true;
            this.text_player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_player.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_player.ForeColor = System.Drawing.Color.White;
            this.text_player.Location = new System.Drawing.Point(12, 9);
            this.text_player.Name = "text_player";
            this.text_player.Size = new System.Drawing.Size(72, 14);
            this.text_player.TabIndex = 0;
            this.text_player.Text = "Music Player";
            // 
            // music_Track_Bar
            // 
            this.music_Track_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.music_Track_Bar.BackColor = System.Drawing.Color.Transparent;
            this.music_Track_Bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.music_Track_Bar.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.music_Track_Bar.BarOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.music_Track_Bar.BarPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.music_Track_Bar.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.music_Track_Bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.music_Track_Bar.DrawFocusRectangle = false;
            this.music_Track_Bar.DrawSemitransparentThumb = false;
            this.music_Track_Bar.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(45)))), ((int)(((byte)(174)))));
            this.music_Track_Bar.ElapsedOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(45)))), ((int)(((byte)(174)))));
            this.music_Track_Bar.Enabled = false;
            this.music_Track_Bar.ForeColor = System.Drawing.Color.Transparent;
            this.music_Track_Bar.LargeChange = ((uint)(1u));
            this.music_Track_Bar.Location = new System.Drawing.Point(336, 89);
            this.music_Track_Bar.MouseEffects = false;
            this.music_Track_Bar.Name = "music_Track_Bar";
            this.music_Track_Bar.Size = new System.Drawing.Size(517, 25);
            this.music_Track_Bar.SmallChange = ((uint)(1u));
            this.music_Track_Bar.TabIndex = 14;
            this.music_Track_Bar.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.music_Track_Bar.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.music_Track_Bar.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.music_Track_Bar.ThumbRoundRectSize = new System.Drawing.Size(23, 23);
            this.music_Track_Bar.ThumbSize = 23;
            this.music_Track_Bar.Value = 0;
            this.music_Track_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Music_Track_Bar_Scroll);
            this.music_Track_Bar.MouseEnter += new System.EventHandler(this.Music_Track_Bar_MouseEnter);
            this.music_Track_Bar.MouseLeave += new System.EventHandler(this.Music_Track_Bar_MouseLeave);
            // 
            // notify_Icon
            // 
            this.notify_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("notify_Icon.Icon")));
            this.notify_Icon.Text = "Music Player";
            this.notify_Icon.DoubleClick += new System.EventHandler(this.Notify_Icon_DoubleClick);
            // 
            // general_panel
            // 
            this.general_panel.BackColor = System.Drawing.Color.Black;
            this.general_panel.Controls.Add(this.minimize_btn);
            this.general_panel.Controls.Add(this.maximize_btn);
            this.general_panel.Controls.Add(this.close_btn);
            this.general_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.general_panel.Location = new System.Drawing.Point(325, 0);
            this.general_panel.Name = "general_panel";
            this.general_panel.Size = new System.Drawing.Size(875, 48);
            this.general_panel.TabIndex = 0;
            this.general_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseDown);
            this.general_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseMove);
            this.general_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Black;
            this.minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(698, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(59, 48);
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.Text = "_";
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            this.minimize_btn.MouseEnter += new System.EventHandler(this.Maximize_and_minimize_btn_MouseEnter);
            this.minimize_btn.MouseLeave += new System.EventHandler(this.Maximize_and_minimize_btn_MouseLeave);
            // 
            // maximize_btn
            // 
            this.maximize_btn.BackColor = System.Drawing.Color.Black;
            this.maximize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximize_btn.FlatAppearance.BorderSize = 0;
            this.maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize_btn.ForeColor = System.Drawing.Color.White;
            this.maximize_btn.Location = new System.Drawing.Point(757, 0);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(59, 48);
            this.maximize_btn.TabIndex = 0;
            this.maximize_btn.Text = "O";
            this.maximize_btn.UseVisualStyleBackColor = false;
            this.maximize_btn.Click += new System.EventHandler(this.Maximize_btn_Click_1);
            this.maximize_btn.MouseEnter += new System.EventHandler(this.Maximize_and_minimize_btn_MouseEnter);
            this.maximize_btn.MouseLeave += new System.EventHandler(this.Maximize_and_minimize_btn_MouseLeave);
            // 
            // music_list_panel
            // 
            this.music_list_panel.Controls.Add(this.about_btn);
            this.music_list_panel.Controls.Add(this.playing_btn);
            this.music_list_panel.Controls.Add(this.songs_btn);
            this.music_list_panel.Controls.Add(this.scroll_close_panel);
            this.music_list_panel.Controls.Add(this.music_list);
            this.music_list_panel.Controls.Add(this.light_panel2);
            this.music_list_panel.Controls.Add(this.line_panel);
            this.music_list_panel.Controls.Add(this.panel1);
            this.music_list_panel.Controls.Add(this.title_btn_general);
            this.music_list_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.music_list_panel.Location = new System.Drawing.Point(325, 48);
            this.music_list_panel.Name = "music_list_panel";
            this.music_list_panel.Size = new System.Drawing.Size(875, 872);
            this.music_list_panel.TabIndex = 3;
            // 
            // about_btn
            // 
            this.about_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about_btn.FlatAppearance.BorderSize = 0;
            this.about_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_btn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_btn.ForeColor = System.Drawing.Color.White;
            this.about_btn.Location = new System.Drawing.Point(368, 75);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(164, 54);
            this.about_btn.TabIndex = 11;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = true;
            this.about_btn.MouseEnter += new System.EventHandler(this.Up_Menu_btn_MouseEnter);
            this.about_btn.MouseLeave += new System.EventHandler(this.Up_Menu_btn_MouseLeave);
            // 
            // playing_btn
            // 
            this.playing_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playing_btn.FlatAppearance.BorderSize = 0;
            this.playing_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playing_btn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playing_btn.ForeColor = System.Drawing.Color.White;
            this.playing_btn.Location = new System.Drawing.Point(196, 75);
            this.playing_btn.Name = "playing_btn";
            this.playing_btn.Size = new System.Drawing.Size(164, 54);
            this.playing_btn.TabIndex = 10;
            this.playing_btn.Text = "Playing";
            this.playing_btn.UseVisualStyleBackColor = true;
            this.playing_btn.MouseEnter += new System.EventHandler(this.Up_Menu_btn_MouseEnter);
            this.playing_btn.MouseLeave += new System.EventHandler(this.Up_Menu_btn_MouseLeave);
            // 
            // songs_btn
            // 
            this.songs_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songs_btn.FlatAppearance.BorderSize = 0;
            this.songs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songs_btn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songs_btn.ForeColor = System.Drawing.Color.White;
            this.songs_btn.Location = new System.Drawing.Point(24, 75);
            this.songs_btn.Name = "songs_btn";
            this.songs_btn.Size = new System.Drawing.Size(164, 54);
            this.songs_btn.TabIndex = 9;
            this.songs_btn.Text = "Songs";
            this.songs_btn.UseVisualStyleBackColor = true;
            this.songs_btn.MouseEnter += new System.EventHandler(this.Up_Menu_btn_MouseEnter);
            this.songs_btn.MouseLeave += new System.EventHandler(this.Up_Menu_btn_MouseLeave);
            // 
            // scroll_close_panel
            // 
            this.scroll_close_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.scroll_close_panel.BackColor = System.Drawing.Color.Black;
            this.scroll_close_panel.Location = new System.Drawing.Point(853, 182);
            this.scroll_close_panel.Name = "scroll_close_panel";
            this.scroll_close_panel.Size = new System.Drawing.Size(22, 517);
            this.scroll_close_panel.TabIndex = 6;
            // 
            // music_list
            // 
            this.music_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.music_list.AutoScroll = true;
            this.music_list.BackColor = System.Drawing.Color.Black;
            this.music_list.Location = new System.Drawing.Point(24, 182);
            this.music_list.Name = "music_list";
            this.music_list.Size = new System.Drawing.Size(851, 517);
            this.music_list.TabIndex = 1;
            // 
            // light_panel2
            // 
            this.light_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.light_panel2.Location = new System.Drawing.Point(24, 135);
            this.light_panel2.Name = "light_panel2";
            this.light_panel2.Size = new System.Drawing.Size(164, 5);
            this.light_panel2.TabIndex = 5;
            this.light_panel2.Visible = false;
            // 
            // line_panel
            // 
            this.line_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line_panel.BackColor = System.Drawing.Color.White;
            this.line_panel.Location = new System.Drawing.Point(24, 137);
            this.line_panel.Name = "line_panel";
            this.line_panel.Size = new System.Drawing.Size(825, 2);
            this.line_panel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 2128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 615);
            this.panel1.TabIndex = 5;
            // 
            // title_btn_general
            // 
            this.title_btn_general.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_btn_general.AutoSize = true;
            this.title_btn_general.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_btn_general.ForeColor = System.Drawing.Color.White;
            this.title_btn_general.Location = new System.Drawing.Point(4, 13);
            this.title_btn_general.Name = "title_btn_general";
            this.title_btn_general.Size = new System.Drawing.Size(189, 39);
            this.title_btn_general.TabIndex = 0;
            this.title_btn_general.Text = "    My music";
            // 
            // music_control_panel
            // 
            this.music_control_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.music_control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.music_control_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.music_control_panel.Controls.Add(this.volume_btn);
            this.music_control_panel.Controls.Add(this.music_progress_total_time);
            this.music_control_panel.Controls.Add(this.music_progress_time);
            this.music_control_panel.Controls.Add(this.random_play_btn);
            this.music_control_panel.Controls.Add(this.replay_btn);
            this.music_control_panel.Controls.Add(this.volume_bar);
            this.music_control_panel.Controls.Add(this.music_Track_Bar);
            this.music_control_panel.Controls.Add(this.right_arrow_btn);
            this.music_control_panel.Controls.Add(this.left_arrow_btn);
            this.music_control_panel.Controls.Add(this.play_btn);
            this.music_control_panel.Location = new System.Drawing.Point(0, 771);
            this.music_control_panel.Name = "music_control_panel";
            this.music_control_panel.Size = new System.Drawing.Size(1200, 149);
            this.music_control_panel.TabIndex = 0;
            // 
            // volume_btn
            // 
            this.volume_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.volume_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.volume_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_btn.Enabled = false;
            this.volume_btn.FlatAppearance.BorderSize = 0;
            this.volume_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volume_btn.Image = ((System.Drawing.Image)(resources.GetObject("volume_btn.Image")));
            this.volume_btn.Location = new System.Drawing.Point(993, 81);
            this.volume_btn.Name = "volume_btn";
            this.volume_btn.Size = new System.Drawing.Size(39, 37);
            this.volume_btn.TabIndex = 18;
            this.volume_btn.UseVisualStyleBackColor = false;
            this.volume_btn.Click += new System.EventHandler(this.Volume_btn_Click);
            this.volume_btn.MouseEnter += new System.EventHandler(this.Volume_btn_MouseEnter);
            this.volume_btn.MouseLeave += new System.EventHandler(this.Volume_btn_MouseLeave);
            // 
            // music_progress_total_time
            // 
            this.music_progress_total_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.music_progress_total_time.AutoSize = true;
            this.music_progress_total_time.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_progress_total_time.ForeColor = System.Drawing.Color.White;
            this.music_progress_total_time.Location = new System.Drawing.Point(859, 90);
            this.music_progress_total_time.Name = "music_progress_total_time";
            this.music_progress_total_time.Size = new System.Drawing.Size(56, 17);
            this.music_progress_total_time.TabIndex = 16;
            this.music_progress_total_time.Text = "00:00:00";
            this.music_progress_total_time.Visible = false;
            // 
            // music_progress_time
            // 
            this.music_progress_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.music_progress_time.AutoSize = true;
            this.music_progress_time.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_progress_time.ForeColor = System.Drawing.Color.White;
            this.music_progress_time.Location = new System.Drawing.Point(274, 92);
            this.music_progress_time.Name = "music_progress_time";
            this.music_progress_time.Size = new System.Drawing.Size(56, 17);
            this.music_progress_time.TabIndex = 15;
            this.music_progress_time.Text = "00:00:00";
            this.music_progress_time.Visible = false;
            // 
            // random_play_btn
            // 
            this.random_play_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.random_play_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.random_play_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.random_play_btn.Enabled = false;
            this.random_play_btn.FlatAppearance.BorderSize = 0;
            this.random_play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_play_btn.Image = global::Music_Player.Properties.Resources.random_gray;
            this.random_play_btn.Location = new System.Drawing.Point(462, 29);
            this.random_play_btn.Name = "random_play_btn";
            this.random_play_btn.Size = new System.Drawing.Size(36, 36);
            this.random_play_btn.TabIndex = 0;
            this.random_play_btn.UseVisualStyleBackColor = false;
            this.random_play_btn.Click += new System.EventHandler(this.Random_play_btn_Click);
            this.random_play_btn.MouseEnter += new System.EventHandler(this.Random_Play_btn_MouseEnter);
            this.random_play_btn.MouseLeave += new System.EventHandler(this.Random_Play_btn_MouseLeave);
            // 
            // replay_btn
            // 
            this.replay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.replay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.replay_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.replay_btn.Enabled = false;
            this.replay_btn.FlatAppearance.BorderSize = 0;
            this.replay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replay_btn.Image = global::Music_Player.Properties.Resources.replay_gray;
            this.replay_btn.Location = new System.Drawing.Point(702, 29);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(36, 36);
            this.replay_btn.TabIndex = 5;
            this.replay_btn.UseVisualStyleBackColor = false;
            this.replay_btn.Click += new System.EventHandler(this.Replay_btn_Click);
            this.replay_btn.MouseEnter += new System.EventHandler(this.Replay_btn_MouseEnter);
            this.replay_btn.MouseLeave += new System.EventHandler(this.Replay_btn_MouseLeave);
            // 
            // volume_bar
            // 
            this.volume_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volume_bar.BackColor = System.Drawing.Color.Transparent;
            this.volume_bar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.volume_bar.BorderColor = System.Drawing.Color.Transparent;
            this.volume_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_bar.Enabled = false;
            this.volume_bar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.volume_bar.IndentHeight = 6;
            this.volume_bar.Location = new System.Drawing.Point(1035, 83);
            this.volume_bar.Margin = new System.Windows.Forms.Padding(0);
            this.volume_bar.Maximum = 100;
            this.volume_bar.Minimum = 0;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.Size = new System.Drawing.Size(130, 33);
            this.volume_bar.TabIndex = 4;
            this.volume_bar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_bar.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.volume_bar.TickHeight = 1;
            this.volume_bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_bar.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.volume_bar.TrackerSize = new System.Drawing.Size(21, 21);
            this.volume_bar.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.volume_bar.TrackLineHeight = 3;
            this.volume_bar.Value = 50;
            this.volume_bar.Scroll += new System.EventHandler(this.Volium_bar_Scroll);
            this.volume_bar.MouseEnter += new System.EventHandler(this.Music_Track_Bar_MouseEnter);
            this.volume_bar.MouseLeave += new System.EventHandler(this.Music_Track_Bar_MouseLeave);
            // 
            // right_arrow_btn
            // 
            this.right_arrow_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.right_arrow_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.right_arrow_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.right_arrow_btn.Enabled = false;
            this.right_arrow_btn.FlatAppearance.BorderSize = 0;
            this.right_arrow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right_arrow_btn.Image = global::Music_Player.Properties.Resources.arrow_right_gray;
            this.right_arrow_btn.Location = new System.Drawing.Point(649, 29);
            this.right_arrow_btn.Name = "right_arrow_btn";
            this.right_arrow_btn.Size = new System.Drawing.Size(40, 40);
            this.right_arrow_btn.TabIndex = 2;
            this.right_arrow_btn.UseVisualStyleBackColor = false;
            this.right_arrow_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Right_arrow_btn_MouseDown);
            this.right_arrow_btn.MouseEnter += new System.EventHandler(this.Right_arrow_btn_MouseEnter);
            this.right_arrow_btn.MouseLeave += new System.EventHandler(this.Right_arrow_btn_MouseLeave);
            // 
            // left_arrow_btn
            // 
            this.left_arrow_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.left_arrow_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.left_arrow_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.left_arrow_btn.Enabled = false;
            this.left_arrow_btn.FlatAppearance.BorderSize = 0;
            this.left_arrow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_arrow_btn.Image = global::Music_Player.Properties.Resources.arrow_left_gray;
            this.left_arrow_btn.Location = new System.Drawing.Point(515, 29);
            this.left_arrow_btn.Name = "left_arrow_btn";
            this.left_arrow_btn.Size = new System.Drawing.Size(40, 40);
            this.left_arrow_btn.TabIndex = 1;
            this.left_arrow_btn.UseVisualStyleBackColor = false;
            this.left_arrow_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_arrow_btn_MouseDown);
            this.left_arrow_btn.MouseEnter += new System.EventHandler(this.Left_arrow_btn_MouseEnter);
            this.left_arrow_btn.MouseLeave += new System.EventHandler(this.Left_arrow_btn_MouseLeave);
            // 
            // play_btn
            // 
            this.play_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.play_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.play_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_btn.Enabled = false;
            this.play_btn.FlatAppearance.BorderSize = 0;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Image = global::Music_Player.Properties.Resources.play_gray;
            this.play_btn.Location = new System.Drawing.Point(568, 20);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(64, 60);
            this.play_btn.TabIndex = 0;
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            this.play_btn.MouseEnter += new System.EventHandler(this.Play_btn_MouseEnter);
            this.play_btn.MouseLeave += new System.EventHandler(this.Play_btn_MouseLeave);
            // 
            // player_refresher
            // 
            this.player_refresher.Interval = 50;
            this.player_refresher.Tick += new System.EventHandler(this.Player_refresher_Tick);
            // 
            // file_open
            // 
            this.file_open.FileName = "openFileDialog1";
            // 
            // Player
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.music_control_panel);
            this.Controls.Add(this.music_list_panel);
            this.Controls.Add(this.general_panel);
            this.Controls.Add(this.menu_bar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_bar_MouseClick);
            this.menu_bar.ResumeLayout(false);
            this.search_box_wrapper.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
            this.general_panel2.ResumeLayout(false);
            this.general_panel2.PerformLayout();
            this.general_panel.ResumeLayout(false);
            this.music_list_panel.ResumeLayout(false);
            this.music_list_panel.PerformLayout();
            this.music_control_panel.ResumeLayout(false);
            this.music_control_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Music_list_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Panel menu_bar;
        private System.Windows.Forms.NotifyIcon notify_Icon;
        private System.Windows.Forms.Panel general_panel2;
        private System.Windows.Forms.Panel general_panel;
        private System.Windows.Forms.Label text_player;
        private System.Windows.Forms.PictureBox menu_btn;
        private System.Windows.Forms.RichTextBox search_box;
        private System.Windows.Forms.PictureBox search_btn;
        private System.Windows.Forms.Button my_music;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button playlists;
        private System.Windows.Forms.Button now_playing;
        private System.Windows.Forms.Button recent_plays;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Panel light_panel;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel music_list_panel;
        private System.Windows.Forms.Label title_btn_general;
        private System.Windows.Forms.Button maximize_btn;
        private System.Windows.Forms.Button minimize_btn;
        private global::Music_Player.Components.Custom_Controls.CirclePicturBox userPicture;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel music_control_panel;
        private Circle_Button random_play_btn;
        private Circle_Button replay_btn;
        private EConTech.Windows.MUSICUI.MusicTrackBar volume_bar;
        private Circle_Button right_arrow_btn;
        private Circle_Button left_arrow_btn;
        private Circle_Button play_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel light_panel2;
        private System.Windows.Forms.Panel search_box_wrapper;
        private System.Windows.Forms.Panel scroll_close_panel;
        private System.Windows.Forms.Panel line_panel;
        private System.Windows.Forms.Panel menu_line;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.FlowLayoutPanel music_list;
        private MB.Controls.ColorSlider music_Track_Bar;
        private System.Windows.Forms.Label music_progress_total_time;
        private System.Windows.Forms.Label music_progress_time;
        private System.Windows.Forms.Timer player_refresher;
        private System.Windows.Forms.OpenFileDialog file_open;
        private Circle_Button volume_btn;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.Button playing_btn;
        private System.Windows.Forms.Button songs_btn;
    }
}

