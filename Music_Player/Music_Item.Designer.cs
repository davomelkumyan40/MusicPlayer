namespace Music_Player
{
    partial class Music_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_Item));
            this.music_name = new System.Windows.Forms.Label();
            this.executor_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.music_size = new System.Windows.Forms.Label();
            this.play_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // music_name
            // 
            this.music_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.music_name.AutoSize = true;
            this.music_name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_name.ForeColor = System.Drawing.Color.White;
            this.music_name.Location = new System.Drawing.Point(150, 37);
            this.music_name.Name = "music_name";
            this.music_name.Size = new System.Drawing.Size(414, 32);
            this.music_name.TabIndex = 0;
            this.music_name.Text = "Lorem Ipsum Somenui fugisra bindus";
            // 
            // executor_name
            // 
            this.executor_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.executor_name.AutoSize = true;
            this.executor_name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executor_name.ForeColor = System.Drawing.Color.White;
            this.executor_name.Location = new System.Drawing.Point(155, 11);
            this.executor_name.Name = "executor_name";
            this.executor_name.Size = new System.Drawing.Size(119, 18);
            this.executor_name.TabIndex = 2;
            this.executor_name.Text = "Executor Name  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // music_size
            // 
            this.music_size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.music_size.AutoSize = true;
            this.music_size.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music_size.ForeColor = System.Drawing.Color.White;
            this.music_size.Location = new System.Drawing.Point(733, 26);
            this.music_size.Name = "music_size";
            this.music_size.Size = new System.Drawing.Size(39, 19);
            this.music_size.TabIndex = 6;
            this.music_size.Text = "3MB";
            // 
            // play_btn
            // 
            this.play_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.play_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_btn.Image = ((System.Drawing.Image)(resources.GetObject("play_btn.Image")));
            this.play_btn.Location = new System.Drawing.Point(647, 19);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(36, 35);
            this.play_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play_btn.TabIndex = 9;
            this.play_btn.TabStop = false;
            this.play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            this.play_btn.MouseEnter += new System.EventHandler(this.Play_btn_MouseEnter);
            this.play_btn.MouseLeave += new System.EventHandler(this.Play_btn_MouseLeave);
            // 
            // Music_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.music_size);
            this.Controls.Add(this.executor_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.music_name);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Music_Item";
            this.Size = new System.Drawing.Size(825, 79);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label music_name;
        private System.Windows.Forms.Label executor_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label music_size;
        private System.Windows.Forms.PictureBox play_btn;
    }
}
