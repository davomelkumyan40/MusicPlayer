namespace Music_Player.Components
{
    partial class Sign_in_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_in_form));
            this.signin_logo = new System.Windows.Forms.Label();
            this.login_box = new System.Windows.Forms.RichTextBox();
            this.vk_logo = new System.Windows.Forms.PictureBox();
            this.sign_in_btn = new System.Windows.Forms.Button();
            this.login_logo = new System.Windows.Forms.PictureBox();
            this.password_logo = new System.Windows.Forms.PictureBox();
            this.login_panel = new System.Windows.Forms.Panel();
            this.password_panel = new System.Windows.Forms.Panel();
            this.password_box = new System.Windows.Forms.TextBox();
            this.remember_me = new System.Windows.Forms.CheckBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.general_panel = new System.Windows.Forms.Panel();
            this.Login_logo_picture = new Music_Player.Components.Custom_Controls.CirclePicturBox();
            ((System.ComponentModel.ISupportInitialize)(this.vk_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_logo)).BeginInit();
            this.login_panel.SuspendLayout();
            this.password_panel.SuspendLayout();
            this.general_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // signin_logo
            // 
            this.signin_logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signin_logo.AutoSize = true;
            this.signin_logo.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.signin_logo.Location = new System.Drawing.Point(261, 48);
            this.signin_logo.Name = "signin_logo";
            this.signin_logo.Size = new System.Drawing.Size(129, 42);
            this.signin_logo.TabIndex = 0;
            this.signin_logo.Text = "Sign In";
            // 
            // login_box
            // 
            this.login_box.BackColor = System.Drawing.Color.White;
            this.login_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_box.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_box.ForeColor = System.Drawing.Color.Gray;
            this.login_box.Location = new System.Drawing.Point(21, 5);
            this.login_box.Margin = new System.Windows.Forms.Padding(0);
            this.login_box.MaxLength = 30;
            this.login_box.Multiline = false;
            this.login_box.Name = "login_box";
            this.login_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.login_box.Size = new System.Drawing.Size(334, 38);
            this.login_box.TabIndex = 0;
            this.login_box.Text = "example@examp.com";
            this.login_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_form_MouseClick);
            // 
            // vk_logo
            // 
            this.vk_logo.Image = ((System.Drawing.Image)(resources.GetObject("vk_logo.Image")));
            this.vk_logo.Location = new System.Drawing.Point(380, 45);
            this.vk_logo.Name = "vk_logo";
            this.vk_logo.Size = new System.Drawing.Size(100, 54);
            this.vk_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vk_logo.TabIndex = 2;
            this.vk_logo.TabStop = false;
            // 
            // sign_in_btn
            // 
            this.sign_in_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(23)))), ((int)(((byte)(152)))));
            this.sign_in_btn.FlatAppearance.BorderSize = 0;
            this.sign_in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in_btn.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_btn.ForeColor = System.Drawing.Color.White;
            this.sign_in_btn.Location = new System.Drawing.Point(196, 490);
            this.sign_in_btn.Name = "sign_in_btn";
            this.sign_in_btn.Size = new System.Drawing.Size(355, 53);
            this.sign_in_btn.TabIndex = 3;
            this.sign_in_btn.Text = "Sign In";
            this.sign_in_btn.UseVisualStyleBackColor = false;
            this.sign_in_btn.Click += new System.EventHandler(this.Signin_btn_Click);
            this.sign_in_btn.MouseEnter += new System.EventHandler(this.Sign_in_btn_MouseEnter);
            this.sign_in_btn.MouseLeave += new System.EventHandler(this.Sign_in_btn_MouseLeave);
            // 
            // login_logo
            // 
            this.login_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_logo.Image = ((System.Drawing.Image)(resources.GetObject("login_logo.Image")));
            this.login_logo.Location = new System.Drawing.Point(124, 289);
            this.login_logo.Name = "login_logo";
            this.login_logo.Size = new System.Drawing.Size(57, 40);
            this.login_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_logo.TabIndex = 7;
            this.login_logo.TabStop = false;
            this.login_logo.Click += new System.EventHandler(this.Login_logo_Click);
            this.login_logo.MouseEnter += new System.EventHandler(this.Login_logo_MouseEnter);
            this.login_logo.MouseLeave += new System.EventHandler(this.Login_logo_MouseLeave);
            // 
            // password_logo
            // 
            this.password_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password_logo.Image = ((System.Drawing.Image)(resources.GetObject("password_logo.Image")));
            this.password_logo.Location = new System.Drawing.Point(124, 379);
            this.password_logo.Name = "password_logo";
            this.password_logo.Size = new System.Drawing.Size(57, 40);
            this.password_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.password_logo.TabIndex = 8;
            this.password_logo.TabStop = false;
            this.password_logo.Click += new System.EventHandler(this.Password_logo_Click);
            this.password_logo.MouseEnter += new System.EventHandler(this.Password_logo_MouseEnter);
            this.password_logo.MouseLeave += new System.EventHandler(this.Password_logo_MouseLeave);
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.White;
            this.login_panel.Controls.Add(this.login_box);
            this.login_panel.Location = new System.Drawing.Point(196, 289);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(355, 43);
            this.login_panel.TabIndex = 10;
            // 
            // password_panel
            // 
            this.password_panel.BackColor = System.Drawing.Color.White;
            this.password_panel.Controls.Add(this.password_box);
            this.password_panel.Location = new System.Drawing.Point(196, 376);
            this.password_panel.Name = "password_panel";
            this.password_panel.Size = new System.Drawing.Size(355, 43);
            this.password_panel.TabIndex = 11;
            // 
            // password_box
            // 
            this.password_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_box.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.password_box.ForeColor = System.Drawing.Color.Gray;
            this.password_box.Location = new System.Drawing.Point(21, 6);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(334, 28);
            this.password_box.TabIndex = 14;
            this.password_box.Text = "***************";
            this.password_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_form_MouseClick);
            // 
            // remember_me
            // 
            this.remember_me.AutoSize = true;
            this.remember_me.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remember_me.ForeColor = System.Drawing.Color.White;
            this.remember_me.Location = new System.Drawing.Point(196, 445);
            this.remember_me.Name = "remember_me";
            this.remember_me.Size = new System.Drawing.Size(132, 23);
            this.remember_me.TabIndex = 2;
            this.remember_me.Text = "Remember me";
            this.remember_me.UseVisualStyleBackColor = true;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Black;
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(670, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(50, 44);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.close_btn.MouseEnter += new System.EventHandler(this.Close_btn_MouseEnter);
            this.close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            // 
            // general_panel
            // 
            this.general_panel.Controls.Add(this.close_btn);
            this.general_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.general_panel.Location = new System.Drawing.Point(0, 0);
            this.general_panel.Name = "general_panel";
            this.general_panel.Size = new System.Drawing.Size(720, 44);
            this.general_panel.TabIndex = 6;
            this.general_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.General_panel_MouseDown);
            this.general_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.General_panel_MouseMove);
            this.general_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.General_panel_MouseUp);
            // 
            // Login_logo_picture
            // 
            this.Login_logo_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(107)))), ((int)(((byte)(236)))));
            this.Login_logo_picture.Image = ((System.Drawing.Image)(resources.GetObject("Login_logo_picture.Image")));
            this.Login_logo_picture.Location = new System.Drawing.Point(290, 115);
            this.Login_logo_picture.Margin = new System.Windows.Forms.Padding(0);
            this.Login_logo_picture.Name = "Login_logo_picture";
            this.Login_logo_picture.Size = new System.Drawing.Size(166, 157);
            this.Login_logo_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_logo_picture.TabIndex = 13;
            this.Login_logo_picture.TabStop = false;
            this.Login_logo_picture.MouseEnter += new System.EventHandler(this.Login_logo_picture_general_MouseEnter);
            this.Login_logo_picture.MouseLeave += new System.EventHandler(this.Login_logo_picture_general_MouseLeave);
            // 
            // Sign_in_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.Login_logo_picture);
            this.Controls.Add(this.remember_me);
            this.Controls.Add(this.password_panel);
            this.Controls.Add(this.password_logo);
            this.Controls.Add(this.login_logo);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.general_panel);
            this.Controls.Add(this.sign_in_btn);
            this.Controls.Add(this.vk_logo);
            this.Controls.Add(this.signin_logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_in_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign  In with VK.com";
            this.Click += new System.EventHandler(this.Sign_in_form_Click);
            ((System.ComponentModel.ISupportInitialize)(this.vk_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_logo)).EndInit();
            this.login_panel.ResumeLayout(false);
            this.password_panel.ResumeLayout(false);
            this.password_panel.PerformLayout();
            this.general_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signin_logo;
        private System.Windows.Forms.RichTextBox login_box;
        private System.Windows.Forms.PictureBox vk_logo;
        private System.Windows.Forms.Button sign_in_btn;
        private System.Windows.Forms.PictureBox login_logo;
        private System.Windows.Forms.PictureBox password_logo;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Panel password_panel;
        private System.Windows.Forms.CheckBox remember_me;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Panel general_panel;
        private Custom_Controls.CirclePicturBox Login_logo_picture;
        private System.Windows.Forms.TextBox password_box;
    }
}