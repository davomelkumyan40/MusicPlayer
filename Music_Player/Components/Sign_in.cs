using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player.Components
{
    public partial class Sign_in_form : Form
    {
        public Sign_in_form(Player player)
        {
            InitializeComponent();
            SetRoundedShape(this, 50);
            SetRoundedShape(login_panel, 30);
            SetRoundedShape(password_panel, 30);
            SetRoundedShape(close_btn, 40);
            SetRoundedShape(sign_in_btn, 40);
            this.player = player;
        }
        private Player player;
        private VKAccount account;


        private void Close_btn_Click(object sender, EventArgs e)
        {
            player.Show();
            Close();
        }

        private async void Signin_btn_Click(object sender, EventArgs e)
        {
            LoadBar loadbar = new LoadBar();
            loadbar.Show();
            this.Hide();
            loadbar.Refresh();
            var client = new VKManager(login_box.Text, password_box.Text);

            if (remember_me.CheckState == CheckState.Checked)
            {
                Task t = new Task(() =>
                {
                    account = client.Authentificate(true);
                });
                t.Start();
                await t;
            }
            else if (remember_me.CheckState == CheckState.Unchecked)
            {
                Task t = new Task(() =>
                {
                    account = client.Authentificate(false);
                });
                t.Start();
                await t;
            }
            loadbar.Close();
            if (account.IsAuthorized)
            {
                player = new Player(account);
                player.Client = client;
                player.Show();
                player.Refresh();
            }
            else
            {
                MusicMessageBox box = new MusicMessageBox();
                box.Show();
                box.ShowWindow(this, MessageFlags.WrongAuth);
            }
            this.Close();
        }

        #region Design

        //Rounded Controls
        private static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new System.Drawing.Region(path);
        }

        //Move Drag Drop
        private bool mouseDown;
        private Point lastLocation;

        private void General_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void General_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void General_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Sign_in_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(232, 151, 232);
            ((Button)sender).Cursor = Cursors.Hand;
        }

        private void Sign_in_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(136, 23, 152);
            ((Button)sender).Cursor = Cursors.Default;
        }

        private void Close_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;
        }

        private void Login_logo_picture_general_MouseEnter(object sender, EventArgs e)
        {
            Login_logo_picture.BackColor = Color.FromArgb(136, 23, 152);
        }

        private void Login_logo_picture_general_MouseLeave(object sender, EventArgs e)
        {
            Login_logo_picture.BackColor = Color.FromArgb(220, 107, 236);
        }

        private void Login_logo_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.login_32_purp;
            ((PictureBox)sender).Refresh();
        }

        private void Login_logo_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.login_32;
            ((PictureBox)sender).Refresh();
        }

        private void Password_logo_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.lock_pass_purp;
            ((PictureBox)sender).Refresh();
        }

        private void Password_logo_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.lock_pass;
            ((PictureBox)sender).Refresh();
        }

        #region PlaceHolder_Login_Password_Form

        //placeholder
        private bool f = false;
        private bool f2 = false;
        private void Login_form_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is RichTextBox rtb)
            {
                if (!f)
                {
                    rtb.Text = string.Empty;
                    rtb.ForeColor = Color.Black;
                    f = true;
                    if (f2 && string.IsNullOrEmpty(password_box.Text))
                    {
                        TextChanger(password_box);
                        f2 = false;
                    }
                }
            }
            else if (sender is TextBox tb)
            {
                if (!f2)
                {
                    tb.Text = string.Empty;
                    tb.ForeColor = Color.Black;
                    f2 = true;
                    if (f && string.IsNullOrEmpty(login_box.Text))
                    {
                        TextChanger(login_box);
                        f = false;
                    }
                }
            }
        }

        //placeholder reset
        private void TextChanger(object sender)
        {
            if (sender is RichTextBox)
            {
                login_box.ForeColor = Color.Gray;
                login_box.Text = Properties.Resources.DefaultLogin;
            }

            else if (sender is TextBox)
            {
                password_box.Text = Properties.Resources.DefaultPassword;
                password_box.ForeColor = Color.Gray;
            }
        }

        private void Sign_in_form_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_box.Text) || login_box.Text == Properties.Resources.DefaultLogin)
            {
                TextChanger(login_box);
                f = false;
            }
            if (string.IsNullOrEmpty(password_box.Text) || password_box.Text == Properties.Resources.DefaultPassword)
            {
                TextChanger(password_box);
                f2 = false;
            }
        }

        private void Login_logo_Click(object sender, EventArgs e)
        {
            login_box.Focus();
            if (string.IsNullOrEmpty(login_box.Text) || login_box.Text == Properties.Resources.DefaultLogin)
                login_box.Text = string.Empty;
            login_box.ForeColor = Color.Black;
            if (string.IsNullOrEmpty(password_box.Text) || password_box.Text == Properties.Resources.DefaultPassword)
                TextChanger(password_box);
        }

        private void Password_logo_Click(object sender, EventArgs e)
        {
            password_box.Focus();
            if (string.IsNullOrEmpty(password_box.Text) || password_box.Text == Properties.Resources.DefaultPassword)
                password_box.Text = string.Empty;
            password_box.ForeColor = Color.Black;
            if (string.IsNullOrEmpty(login_box.Text) || login_box.Text == Properties.Resources.DefaultLogin)
                TextChanger(login_box);
        }

        #endregion

        #endregion
    }
}
