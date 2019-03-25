
namespace Music_Player.Components
{
    partial class MusicMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicMessageBox));
            this.global_message = new System.Windows.Forms.Label();
            this.dont_run_btn = new System.Windows.Forms.Button();
            this.run_anyway_btn = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.success_png = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.success_png)).BeginInit();
            this.SuspendLayout();
            // 
            // global_message
            // 
            this.global_message.AutoSize = true;
            this.global_message.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.global_message.Location = new System.Drawing.Point(36, 41);
            this.global_message.Name = "global_message";
            this.global_message.Size = new System.Drawing.Size(443, 40);
            this.global_message.TabIndex = 1;
            this.global_message.Text = "Oops, Something\'s going wrong !";
            // 
            // dont_run_btn
            // 
            this.dont_run_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dont_run_btn.FlatAppearance.BorderSize = 4;
            this.dont_run_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dont_run_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dont_run_btn.Location = new System.Drawing.Point(364, 514);
            this.dont_run_btn.Name = "dont_run_btn";
            this.dont_run_btn.Size = new System.Drawing.Size(148, 46);
            this.dont_run_btn.TabIndex = 2;
            this.dont_run_btn.Text = "Don\'t run";
            this.dont_run_btn.UseVisualStyleBackColor = true;
            this.dont_run_btn.Click += new System.EventHandler(this.Dont_run_btn_Click);
            // 
            // run_anyway_btn
            // 
            this.run_anyway_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.run_anyway_btn.FlatAppearance.BorderSize = 4;
            this.run_anyway_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run_anyway_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_anyway_btn.Location = new System.Drawing.Point(542, 514);
            this.run_anyway_btn.Name = "run_anyway_btn";
            this.run_anyway_btn.Size = new System.Drawing.Size(148, 46);
            this.run_anyway_btn.TabIndex = 3;
            this.run_anyway_btn.Text = "Run anyway";
            this.run_anyway_btn.UseVisualStyleBackColor = true;
            this.run_anyway_btn.Click += new System.EventHandler(this.Run_anyway_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.message.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(39, 142);
            this.message.Margin = new System.Windows.Forms.Padding(0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(543, 120);
            this.message.TabIndex = 4;
            this.message.Text = resources.GetString("message.Text");
            // 
            // close_btn
            // 
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(671, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(49, 46);
            this.close_btn.TabIndex = 5;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.Dont_run_btn_Click);
            // 
            // success_png
            // 
            this.success_png.Image = ((System.Drawing.Image)(resources.GetObject("success_png.Image")));
            this.success_png.Location = new System.Drawing.Point(269, 237);
            this.success_png.Name = "success_png";
            this.success_png.Size = new System.Drawing.Size(165, 147);
            this.success_png.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.success_png.TabIndex = 6;
            this.success_png.TabStop = false;
            this.success_png.Visible = false;
            // 
            // MusicMessageBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.success_png);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.message);
            this.Controls.Add(this.run_anyway_btn);
            this.Controls.Add(this.dont_run_btn);
            this.Controls.Add(this.global_message);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarningMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.success_png)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label global_message;
        private System.Windows.Forms.Button dont_run_btn;
        private System.Windows.Forms.Button run_anyway_btn;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.PictureBox success_png;
    }
}