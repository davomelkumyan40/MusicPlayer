namespace Music_Player.Components
{
    partial class LoadBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadBar));
            this.loading_text = new System.Windows.Forms.Label();
            this.loader = new System.Windows.Forms.Timer(this.components);
            this.load_panel = new System.Windows.Forms.Panel();
            this.load_item1 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item2 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item5 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item3 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item6 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item4 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item7 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item15 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item8 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item14 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item9 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item13 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item10 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item12 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.load_item11 = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.Login_logo_picture_panel = new Music_Player.Components.Custom_Controls.CirclePanel();
            this.user_logo = new System.Windows.Forms.PictureBox();
            this.load_panel.SuspendLayout();
            this.Login_logo_picture_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // loading_text
            // 
            this.loading_text.AutoSize = true;
            this.loading_text.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_text.ForeColor = System.Drawing.Color.White;
            this.loading_text.Location = new System.Drawing.Point(258, 495);
            this.loading_text.Name = "loading_text";
            this.loading_text.Size = new System.Drawing.Size(219, 45);
            this.loading_text.TabIndex = 1;
            this.loading_text.Text = "Signing In...";
            // 
            // loader
            // 
            this.loader.Interval = 40;
            this.loader.Tick += new System.EventHandler(this.loader_Tick);
            // 
            // load_panel
            // 
            this.load_panel.Controls.Add(this.load_item1);
            this.load_panel.Controls.Add(this.load_item2);
            this.load_panel.Controls.Add(this.load_item5);
            this.load_panel.Controls.Add(this.load_item3);
            this.load_panel.Controls.Add(this.load_item6);
            this.load_panel.Controls.Add(this.load_item4);
            this.load_panel.Controls.Add(this.load_item7);
            this.load_panel.Controls.Add(this.load_item15);
            this.load_panel.Controls.Add(this.load_item8);
            this.load_panel.Controls.Add(this.load_item14);
            this.load_panel.Controls.Add(this.load_item9);
            this.load_panel.Controls.Add(this.load_item13);
            this.load_panel.Controls.Add(this.load_item10);
            this.load_panel.Controls.Add(this.load_item12);
            this.load_panel.Controls.Add(this.load_item11);
            this.load_panel.Location = new System.Drawing.Point(278, 267);
            this.load_panel.Name = "load_panel";
            this.load_panel.Size = new System.Drawing.Size(166, 157);
            this.load_panel.TabIndex = 32;
            // 
            // load_item1
            // 
            this.load_item1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item1.Location = new System.Drawing.Point(84, 23);
            this.load_item1.Name = "load_item1";
            this.load_item1.Size = new System.Drawing.Size(10, 10);
            this.load_item1.TabIndex = 17;
            // 
            // load_item2
            // 
            this.load_item2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item2.Location = new System.Drawing.Point(105, 30);
            this.load_item2.Name = "load_item2";
            this.load_item2.Size = new System.Drawing.Size(10, 10);
            this.load_item2.TabIndex = 18;
            // 
            // load_item5
            // 
            this.load_item5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item5.Location = new System.Drawing.Point(132, 83);
            this.load_item5.Name = "load_item5";
            this.load_item5.Size = new System.Drawing.Size(10, 10);
            this.load_item5.TabIndex = 31;
            // 
            // load_item3
            // 
            this.load_item3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item3.Location = new System.Drawing.Point(122, 44);
            this.load_item3.Name = "load_item3";
            this.load_item3.Size = new System.Drawing.Size(10, 10);
            this.load_item3.TabIndex = 19;
            // 
            // load_item6
            // 
            this.load_item6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item6.Location = new System.Drawing.Point(124, 104);
            this.load_item6.Name = "load_item6";
            this.load_item6.Size = new System.Drawing.Size(10, 10);
            this.load_item6.TabIndex = 30;
            // 
            // load_item4
            // 
            this.load_item4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item4.Location = new System.Drawing.Point(131, 62);
            this.load_item4.Name = "load_item4";
            this.load_item4.Size = new System.Drawing.Size(10, 10);
            this.load_item4.TabIndex = 20;
            // 
            // load_item7
            // 
            this.load_item7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item7.Location = new System.Drawing.Point(108, 120);
            this.load_item7.Name = "load_item7";
            this.load_item7.Size = new System.Drawing.Size(10, 10);
            this.load_item7.TabIndex = 29;
            // 
            // load_item15
            // 
            this.load_item15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item15.Location = new System.Drawing.Point(62, 26);
            this.load_item15.Name = "load_item15";
            this.load_item15.Size = new System.Drawing.Size(10, 10);
            this.load_item15.TabIndex = 21;
            // 
            // load_item8
            // 
            this.load_item8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item8.Location = new System.Drawing.Point(89, 128);
            this.load_item8.Name = "load_item8";
            this.load_item8.Size = new System.Drawing.Size(10, 10);
            this.load_item8.TabIndex = 28;
            // 
            // load_item14
            // 
            this.load_item14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item14.Location = new System.Drawing.Point(42, 38);
            this.load_item14.Name = "load_item14";
            this.load_item14.Size = new System.Drawing.Size(10, 10);
            this.load_item14.TabIndex = 22;
            // 
            // load_item9
            // 
            this.load_item9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item9.Location = new System.Drawing.Point(68, 128);
            this.load_item9.Name = "load_item9";
            this.load_item9.Size = new System.Drawing.Size(10, 10);
            this.load_item9.TabIndex = 27;
            // 
            // load_item13
            // 
            this.load_item13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item13.Location = new System.Drawing.Point(29, 57);
            this.load_item13.Name = "load_item13";
            this.load_item13.Size = new System.Drawing.Size(10, 10);
            this.load_item13.TabIndex = 23;
            // 
            // load_item10
            // 
            this.load_item10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item10.Location = new System.Drawing.Point(49, 118);
            this.load_item10.Name = "load_item10";
            this.load_item10.Size = new System.Drawing.Size(10, 10);
            this.load_item10.TabIndex = 26;
            // 
            // load_item12
            // 
            this.load_item12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item12.Location = new System.Drawing.Point(27, 80);
            this.load_item12.Name = "load_item12";
            this.load_item12.Size = new System.Drawing.Size(10, 10);
            this.load_item12.TabIndex = 24;
            // 
            // load_item11
            // 
            this.load_item11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load_item11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.load_item11.Location = new System.Drawing.Point(34, 102);
            this.load_item11.Name = "load_item11";
            this.load_item11.Size = new System.Drawing.Size(10, 10);
            this.load_item11.TabIndex = 25;
            // 
            // Login_logo_picture_panel
            // 
            this.Login_logo_picture_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(107)))), ((int)(((byte)(236)))));
            this.Login_logo_picture_panel.Controls.Add(this.user_logo);
            this.Login_logo_picture_panel.Location = new System.Drawing.Point(278, 46);
            this.Login_logo_picture_panel.Name = "Login_logo_picture_panel";
            this.Login_logo_picture_panel.Size = new System.Drawing.Size(166, 157);
            this.Login_logo_picture_panel.TabIndex = 33;
            // 
            // user_logo
            // 
            this.user_logo.BackColor = System.Drawing.Color.Transparent;
            this.user_logo.Image = ((System.Drawing.Image)(resources.GetObject("user_logo.Image")));
            this.user_logo.Location = new System.Drawing.Point(27, 25);
            this.user_logo.Name = "user_logo";
            this.user_logo.Size = new System.Drawing.Size(112, 106);
            this.user_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_logo.TabIndex = 0;
            this.user_logo.TabStop = false;
            // 
            // LoadBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.Login_logo_picture_panel);
            this.Controls.Add(this.load_panel);
            this.Controls.Add(this.loading_text);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signing In";
            this.load_panel.ResumeLayout(false);
            this.Login_logo_picture_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loading_text;
        private System.Windows.Forms.Timer loader;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item1;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item5;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item6;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item7;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item8;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item9;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item10;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item11;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item12;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item13;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item14;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item15;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item4;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item3;
        private global::Music_Player.Components.Custom_Controls.CirclePanel load_item2;
        private System.Windows.Forms.Panel load_panel;
        private global::Music_Player.Components.Custom_Controls.CirclePanel Login_logo_picture_panel;
        private System.Windows.Forms.PictureBox user_logo;
    }
}