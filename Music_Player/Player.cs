using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Music_Player.Components;
using System.Threading.Tasks;
using EConTech.Windows.MUSICUI;
using MB.Controls;
using Player_Core;

namespace Music_Player
{
    public partial class Player : Form
    {
        public Player()
        {
            bool rememberMe = false;
            InitializeComponent();
            //SetRoundedShape(this, 40);
            account = new VKAccount();
            InitFolders();

            if (rememberMe)
            {
                try
                {
                    Client = new VKManager();
                    Client.AuthentificateFromFile(File.ReadAllText(Properties.Resources.UserDataJSONPath), Properties.Resources.SecretUserJSONDataPath);
                }
                catch (Exception ex)
                {
                    MusicMessageBox box = new MusicMessageBox();
                    box.ShowWindow(this, ex.Message);
                }
            }

        }

        public Player(VKAccount account)
        {
            InitializeComponent();
            SetRoundedShape(this, 30);
            this.account = account;
            RefreshLoginPanel();
        }

        private void InitFolders()
        {
            if (!Directory.Exists(Properties.Resources.PublicMusicFolder))
                Directory.CreateDirectory(Properties.Resources.PublicMusicFolder);
            if (!File.Exists(Properties.Resources.SettingsXML))
                using (File.Create(Properties.Resources.SettingsXML)) { }
            if (!File.Exists(Properties.Resources.SecretUserJSONDataPath))
                using (File.Create(Properties.Resources.SecretUserJSONDataPath)) { }
            if (!File.Exists(Properties.Resources.UserAccauntDataPath))
                using (File.Create(Properties.Resources.UserAccauntDataPath)) { }
            if (!File.Exists(Properties.Resources.UserDataJSONPath))
                using (File.Create(Properties.Resources.UserDataJSONPath)) { }
        }

        //Rounded Controls
        private void SetRoundedShape(Control control, int radius)
        {
            if(this.WindowState != FormWindowState.Maximized)
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
                control.Region = new Region(path);
            }
        }

        #region Desighn

        //Move Drag Drop
        private bool mouseDown;
        private Point lastLocation;

        private void generalPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void generalPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void generalPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Close_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;
        }

        private void Maximize_and_minimize_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(63, 60, 65);
        }

        private void Maximize_and_minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void Menu_btn_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(63, 60, 65);
        }

        private void Menu_btn_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void Search_btn_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.search_purple;
            ((PictureBox)sender).Refresh();
        }

        private void Search_btn_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.search_white;
            ((PictureBox)sender).Refresh();
        }

        private void Search_box_MouseDown(object sender, MouseEventArgs e)
        {
            ((RichTextBox)sender).BackColor = Color.FromArgb(25, 25, 25);
            search_box_wrapper.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void Menu_bar_MouseClick(object sender, MouseEventArgs e)
        {
            if (search_box.BackColor == Color.FromArgb(25, 25, 25) && closed)
            {
                search_box.BackColor = Color.FromArgb(35, 35, 35);
                search_btn.BackColor = Color.FromArgb(35, 35, 35);
                search_box_wrapper.BackColor = Color.FromArgb(35, 35, 35);
                if (sender is Panel)
                    ((Panel)sender).Focus();
                if (sender is Form)
                    menu_bar.Focus();
            }
        }

        private void menu_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(63, 60, 65);
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = ((Control)sender);
            List<char> arr = null;
            string text = string.Empty;
            if (c.Text != "+")
            {
                if (c.Text.Contains(' '))
                {
                    arr = c.Text.ToList();
                    while (arr[0] == ' ')
                    {
                        arr.RemoveAt(0);
                    }
                    text = new string(arr.ToArray<char>());
                }
                else
                    text = c.Text;
                title_btn_general.Text = new string(' ', 4) + text;
            }
            light_panel.Height = c.Height;
            light_panel.Top = c.Top;
            menu_bar.Refresh();
        }

        private void Play_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.play_white;
            ((Button)sender).Refresh();
        }

        private void Play_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.play_gray;
            ((Button)sender).Refresh();
        }

        private void Left_arrow_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.arrow_left_white;
            ((Button)sender).Refresh();
        }

        private void Left_arrow_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.arrow_left_gray;
            ((Button)sender).Refresh();
        }

        private void Right_arrow_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.arrow_right_white;
            ((Button)sender).Refresh();
        }

        private void Right_arrow_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.arrow_right_gray;
            ((Button)sender).Refresh();
        }

        private bool closed = false;
        private void Menu_btn_Click(object sender, EventArgs e)
        {
            if (!closed)
            {
                if (account.IsAuthorized)
                {
                    login_btn.Location = new Point(0, 0);
                    userPicture.Location = new Point(5, 0);
                }
                CloseWinBar();
            }
            else
            {
                login_btn.Location = new Point(12, 0);
                userPicture.Location = new Point(12, 0);
                OpenWinBar();
            }
            this.Refresh();
        }

        private void CloseWinBar()
        {
            if (music_list.Controls.Count == 0)
                music_list.Hide();
            menu_line.Hide();
            if (account.IsAuthorized)
                logout_btn.Location = new Point(12, logout_btn.Location.Y + 56);
            plus_btn.Location = new Point(12, plus_btn.Location.Y + 57);
            search_box.Hide();
            search_box_wrapper.Hide();
            search_btn.Location = new Point(0, 94);
            text_player.Hide();
            for (int i = 0; i < 26; i++)
            {
                music_list_panel.Width += 10;
                menu_bar.Width -= 10;
            }
            menu_bar.Width -= 5;
            music_list_panel.Width += 5;
            if (music_list.Controls.Count != 0)
            {
                foreach (Music_Item musicItem in music_list.Controls)
                {
                    musicItem.Size = new Size(music_list.Size.Width - 26, musicItem.Size.Height);
                }
            }
            closed = true;
        }

        private void OpenWinBar()
        {
            if (music_list.Controls.Count == 0)
                music_list.Hide();
            if (music_list.Controls.Count != 0)
            {
                foreach (Music_Item musicItem in music_list.Controls)
                {
                    musicItem.Size = new Size(music_list.Size.Width - 265 - 26, musicItem.Size.Height);
                }
            }
            menu_line.Show();
            plus_btn.Location = new Point(271, 298);
            logout_btn.Location = new Point(12, logout_btn.Location.Y - 56);
            search_box.Show();
            search_box_wrapper.Show();
            search_btn.Location = new Point(260, 94);
            for (int i = 0; i < 26; i++)
            {
                this.Update();
                menu_bar.Width += 10;
                music_list_panel.Width -= 10;
            }
            menu_bar.Width += 5;
            music_list_panel.Width -= 5;
            text_player.Show();
            closed = false;
        }

        private bool first = false;
        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (closed)
            {
                if (first)
                {
                    search_box.Text = string.Empty;
                    first = true;
                }
                else
                {

                }
                if (music_list.Controls.Count == 0)
                    music_list.Hide();
                OpenWinBar();
                search_box.BackColor = Color.FromArgb(25, 25, 25);
                search_box_wrapper.BackColor = Color.FromArgb(25, 25, 25);
                search_box.Focus();
                music_list.Show();
                Refresh();
            }
        }

        #endregion


        #region Logic

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            notify_Icon.Visible = true;
        }

        private void Notify_Icon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            notify_Icon.Visible = false;
        }


        private VKAccount account { get; set; }
        public VKManager Client { get; set; }
        private string UserDataJSON = string.Empty;
        private string SecretUserJSON = string.Empty;
        private async void login_btn_Click(object sender, EventArgs e)
        {
            music_list.Hide();
            if (!account.IsAuthorized)
            {
                BassCore.Stop();
                PlayerDefaultSet(true);
                play_btn.Image = Properties.Resources.play_gray;
                using (var stream = new FileStream(Properties.Resources.UserDataJSONPath, FileMode.Open))
                {
                    using (var stream2 = new FileStream(Properties.Resources.SecretUserJSONDataPath, FileMode.Open))
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            UserDataJSON = reader.ReadToEnd();
                            if (string.IsNullOrEmpty(UserDataJSON))
                            {
                                var form = new Sign_in_form(this);
                                form.Show();
                                this.Hide();
                                form.BringToFront();
                            }
                            else
                            {
                                LoadBar bar = new LoadBar();
                                this.Hide();
                                bar.Show();
                                SecretUserJSON = new StreamReader(stream2).ReadToEnd();
                                Client = new VKManager();
                                Task t = new Task(() =>
                                {
                                    account = Client.AuthentificateFromFile(UserDataJSON, SecretUserJSON);
                                });
                                t.Start();
                                await t;
                                this.Show();
                                RefreshLoginPanel();
                                bar.Close();
                            }
                        }
                    }
                }
            }
            if (account.IsAuthorized && closed)
            {
                login_btn.Location = new Point(0, 0);
                userPicture.Location = new Point(5, 0);
            }
            Refresh();
        }

        private void RefreshLoginPanel()
        {
            login_btn.Image = default(Image);
            userPicture.Image = account.UserImage;
            userPicture.Visible = true;
            userPicture.SizeMode = PictureBoxSizeMode.Zoom;
            login_btn.Text = $"{account.Name}  {account.SurName}";
            logout_btn.Visible = true;
            logout_btn.Enabled = true;
            title_btn_general.Text = $"{new string(' ', 4)}{account.Name}  {account.SurName }";
        }

        #endregion

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                BassCore.Stop();
                PlayerDefaultSet(true);
            }

            music_list.Hide();
            music_list.Controls.Clear();
            login_btn.Location = new Point(12, 0);
            userPicture.Location = new Point(12, 0);
            account = new VKAccount();
            Client = null;
            login_btn.Text = "Sign  In";
            login_btn.Image = Properties.Resources.login_32;
            userPicture.Visible = false;
            Refresh();
            logout_btn.Enabled = false;
            logout_btn.Visible = false;
            light_panel.Location = new Point(3, 0);
            title_btn_general.Text = new string(' ', 4) + login_btn.Text;
        }

        private void Replay_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.replay_white;
            ((Button)sender).Refresh();
        }

        private void Replay_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.replay_gray;
            ((Button)sender).Refresh();
        }

        private void Music_Track_Bar_MouseEnter(object sender, EventArgs e)
        {
            if (sender is MusicTrackBar)
            {
                ((MusicTrackBar)sender).TrackLineColor = Color.White;
                ((MusicTrackBar)sender).BaseColor = Color.White;
                ((MusicTrackBar)sender).Refresh();
            }
            else if (sender is ColorSlider)
            {
                ((ColorSlider)sender).BarInnerColor = Color.White;
                ((ColorSlider)sender).Refresh();
            }

        }

        private void Music_Track_Bar_MouseLeave(object sender, EventArgs e)
        {

            if (sender is MusicTrackBar)
            {
                ((MusicTrackBar)sender).TrackLineColor = Color.FromArgb(86, 86, 86);
                ((MusicTrackBar)sender).BaseColor = Color.FromArgb(86, 86, 86);
                ((MusicTrackBar)sender).Refresh();
            }
            else if (sender is ColorSlider)
            {
                ((ColorSlider)sender).BarInnerColor = Color.FromArgb(125, 125, 125);
                ((ColorSlider)sender).Refresh();
            }

        }

        private void Random_Play_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.random_white;
            ((Button)sender).Refresh();
        }

        private void Random_Play_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.random_gray;
            ((Button)sender).Refresh();
        }

        private void Maximize_btn_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                ((Button)sender).Image = Properties.Resources.normalize;
            }
            else
            {
                ((Button)sender).Image = Properties.Resources.maximize;
                WindowState = FormWindowState.Normal;
            }
            Refresh();
        }


        #region MusicListDraw

        private const int ItemMargin = 5;
        private const float PictureHeight = 70f;


        // Return enough space for the item.
        private void lstMusics_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)(PictureHeight + 2 * ItemMargin);
        }

        // Draw the item.
        private void lstMusics_DrawItem(object sender, DrawItemEventArgs e)
        {

            Brush b = new SolidBrush(Color.FromArgb(44, 44, 44));


            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            Music music = (Music)lst.Items[e.Index];

            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics,
                          e.Font,
                          e.Bounds,
                          e.Index,
                          e.State ^ DrawItemState.Selected,
                          e.ForeColor,
                          Color.FromArgb(59, 0, 75));
            }


            // Draw the background.
            e.DrawBackground();

            // Draw the picture.
            float scale = PictureHeight / music.Picture.Height;
            RectangleF source_rect = new RectangleF(
                0, 0, music.Picture.Width, music.Picture.Height);
            float picture_width = scale * music.Picture.Width;
            RectangleF dest_rect = new RectangleF(
                e.Bounds.Left + ItemMargin, e.Bounds.Top + ItemMargin,
                picture_width, PictureHeight);
            e.Graphics.DrawImage(music.Picture, dest_rect, source_rect, GraphicsUnit.Pixel);

            // See if the item is selected.
            Brush br;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                br = SystemBrushes.HighlightText;
            else
                br = new SolidBrush(e.ForeColor);

            // Find the area in which to put the text.
            float x = e.Bounds.Left + picture_width + 3 * ItemMargin;
            float y = e.Bounds.Top + ItemMargin;
            float width = e.Bounds.Right - ItemMargin - x;
            float height = e.Bounds.Bottom - ItemMargin - y;
            RectangleF layout_rect = new RectangleF(x, y, width, height);




            Pen p = new Pen(Color.Black, 5);
            // Drawing rectangle for bounds
            e.Graphics.DrawRectangle(p, new Rectangle(((int)x - 160), (int)y - 5, ((int)width + 170), ((int)height) + 10));
            //e.Graphics.DrawLine(p,x + 1500, y - 250, x, y - 250);

            // Draw the text.
            string nameText = '\n' + music.Name;
            e.Graphics.DrawString(music.Executor, new Font("Segoe UI", 10), br, layout_rect);
            e.Graphics.DrawString(nameText, music_list.Font, br, layout_rect);
            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }
        #endregion


        private bool downloaded = false;
        private async void Download_btn_Click(object sender, EventArgs e)
        {
            music_list.Hide();
            if (account.IsAuthorized)
            {
                try
                {
                    this.Hide();
                    this.title_btn_general.Text = new string(' ', 4) + download_btn.Text;
                    LoadBar bar = new LoadBar(Properties.Resources.WhileDownloadingText + " \n\r        Plaese Wait...");
                    bar.Font = new Font("Segoe UI", 24f);
                    bar.TextPosition = new Point(154, 460);
                    bar.Show();
                    Task t = new Task(() =>
                    {
                        Client.DownloadAllMusic();
                    });
                    t.Start();
                    await t;
                    bar.Close();
                    MusicMessageBox box = new MusicMessageBox();
                    box.ShowWindow(this, MessageFlags.Success);
                    box.Show();
                    downloaded = true;
                }
                catch (Exception ex)
                {
                    MusicMessageBox box = new MusicMessageBox();
                    box.Show();
                    box.ShowWindow(this, ex.Message);
                }
            }

        }

        private void My_music_Click(object sender, EventArgs e)
        {
            random_play_btn.Enabled = true;
            left_arrow_btn.Enabled = true;
            play_btn.Enabled = true;
            replay_btn.Enabled = true;
            volume_btn.Enabled = true;
            right_arrow_btn.Enabled = true;
            music_list.Show();
            selectedMusicIndex = -1;
            selectedMusic = null;
            if (account.IsAuthorized && downloaded)
            {
                var audioInfos = Client.AudioList.OrderBy((c) => c.Title).ToList();
                music_list.Controls.Clear();
                foreach (var music in audioInfos)
                {
                    var item = new Music_Item()
                    {
                        ArtistName = music.Artist,
                        Name = music.Title + music.Artist
                    };
                    item.Size = new Size(music_list.Size.Width - 26, item.Size.Height);
                    item.MouseClick += Item_MouseClick;
                    music_list.Controls.Add(item);
                    item.Index = music_list.Controls.IndexOf(item);
                }
            }
            else if (!account.IsAuthorized)
            {
                if (Client == null)
                    Client = new VKManager();
                music_list.Controls.Clear();
                foreach (string music in Client.FileList)
                {
                    var item = new Music_Item();
                    item.Name = Path.GetFileNameWithoutExtension(music);
                    item.ArtistName = Properties.Resources.UnknownMusicArtist;
                    item.Size = new Size(music_list.Size.Width - 26, item.Size.Height);
                    item.MouseClick += Item_MouseClick;
                    music_list.Controls.Add(item);
                    item.Index = music_list.Controls.IndexOf(item);
                }
                Client = null;
            }
            Refresh();
        }

        #region PlayFuncPart

        private int prevSelectedMusicIndex = -1;
        private int selectedMusicIndex = -1;
        private Music_Item selectedMusic;
        private Music_Item prevControl;
        private void Item_MouseClick(object sender, EventArgs e)
        {
            music_control_panel.Enabled = true;
            selectedMusic = ((Music_Item)sender);
            if (prevControl != ((Music_Item)sender) && prevControl != null)
            {
                selectedMusic.BackColor = Color.FromArgb(36, 0, 47);
                prevControl.BackColor = Color.FromArgb(44, 44, 44);
            }
            else
            {
                selectedMusic.BackColor = Color.FromArgb(36, 0, 47);
            }
            prevControl = ((Music_Item)sender);
            selectedMusicIndex = music_list.Controls.IndexOf(((Music_Item)sender));
            newPlaying = true;
            music_list.Refresh();
        }

        private void Pause_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.pause_white;
            ((Button)sender).Refresh();
        }

        private void Pause_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.pause_gray;
            ((Button)sender).Refresh();
        }


        private bool newPlaying = true;
        private bool playing = false;
        private void Play_btn_Click(object sender, EventArgs e)
        {
            if (selectedMusicIndex != -1)
            {
                music_Track_Bar.Enabled = true;
                volume_bar.Enabled = true;
                volume_btn.Enabled = true;
                Play(sender);
            }
        }

        private void Play(object sender)
        {
            if (!playing)
            {
                if (selectedMusicIndex == -1)
                {
                    music_Track_Bar.Enabled = false;
                    volume_bar.Enabled = false;
                    volume_btn.Enabled = false;
                    return;
                }

                ((Button)sender).Image = Properties.Resources.pause_white;
                if (Client == null)
                {
                    Client = new VKManager();
                }
                if (newPlaying)
                    BassCore.Play(Client.FileList[selectedMusicIndex], BassCore.Volume);
                else
                    BassCore.Continue(BassCore.Stream);
                PlayerSet();
            }
            else
            {
                ((Button)sender).Image = Properties.Resources.play_white;
                if (selectedMusicIndex == prevSelectedMusicIndex)
                {
                    BassCore.Pause();
                    PlayerDefaultSet(false);
                }
                else if (selectedMusicIndex != prevSelectedMusicIndex)
                {
                    BassCore.Stop();
                    PlayerDefaultSet(true);
                }
            }
            ((Button)sender).Refresh();
            prevSelectedMusicIndex = selectedMusicIndex;
        }

        private void PlayerSet()
        {
            playing = true;
            newPlaying = false;
            music_progress_time.Show();
            music_progress_total_time.Show();
            music_Track_Bar.Maximum = BassCore.GetLengthOfStream(BassCore.Stream);
            music_progress_total_time.Text = TimeSpan.FromSeconds(BassCore.GetLengthOfStream(BassCore.Stream)).ToString();
            play_btn.MouseEnter -= Play_btn_MouseEnter;
            play_btn.MouseLeave -= Play_btn_MouseLeave;
            play_btn.MouseEnter += Pause_btn_MouseEnter;
            play_btn.MouseLeave += Pause_btn_MouseLeave;
            player_refresher.Start();
        }


        private static Random rnd = new Random();
        private void PlayNext(PlayerActions action)
        {

            if (action == PlayerActions.RandomPlay)
            {
                int randomIndex = rnd.Next(0, Client.FileList.Length);
                while (randomIndex == selectedMusicIndex)
                {
                    randomIndex = rnd.Next(0, Client.FileList.Length);
                }
                selectedMusicIndex = randomIndex;
            }
            else if (action == PlayerActions.RePlay)
            {
                BassCore.Play(Client.FileList[selectedMusicIndex], volume_bar.Value);
                return;
            }
            else
            {
                if (Client.FileList.Length > (selectedMusicIndex + 1))
                {
                    selectedMusicIndex += 1;
                }
                else if (Client.FileList.Length == 1)
                    BassCore.Play(Client.FileList[selectedMusicIndex], volume_bar.Value);
                else if (selectedMusicIndex == (Client.FileList.Length - 1))
                {
                    selectedMusicIndex = 0;
                }
            }
            BassCore.Play(Client.FileList[selectedMusicIndex], volume_bar.Value);
            prevSelectedMusicIndex = selectedMusicIndex;
            PlayerSet();
        }

        private void Player_refresher_Tick(object sender, EventArgs e)
        {
            if (playing)
            {
                music_progress_time.Text = TimeSpan.FromSeconds(BassCore.GetStreamPosition(BassCore.Stream)).ToString();
                music_Track_Bar.Value = BassCore.GetStreamPosition(BassCore.Stream);
                if (music_progress_time.Text == music_progress_total_time.Text)
                {
                    BassCore.Stop();
                    PlayNext(action);
                }
            }
            else
            {
                BassCore.Stop();
                PlayerDefaultSet(true);
            }
        }

        private void PlayerDefaultSet(bool withValueReset)
        {
            playing = false;
            play_btn.MouseEnter -= Pause_btn_MouseEnter;
            play_btn.MouseLeave -= Pause_btn_MouseLeave;
            play_btn.MouseEnter += Play_btn_MouseEnter;
            play_btn.MouseLeave += Play_btn_MouseLeave;
            newPlaying = false;
            player_refresher.Stop();
            if (withValueReset)
            {
                newPlaying = true;
                music_Track_Bar.Value = 0;
            }
        }

        private void Music_Track_Bar_Scroll(object sender, ScrollEventArgs e)
        {
            BassCore.SetChannelPosition(BassCore.Stream, music_Track_Bar.Value);
        }

        #endregion

        private void Volium_bar_Scroll(object sender, EventArgs e)
        {
            BassCore.SetVolumeToStream(BassCore.Stream, volume_bar.Value);
            ToVolGray();
            volume_btn.Refresh();
        }

        private void ToVolWhite()
        {
            if (volume_bar.Value < 1)
                volume_btn.Image = Properties.Resources.volume_white_no;
            if (volume_bar.Value < 40 && volume_bar.Value > 2)
                volume_btn.Image = Properties.Resources.volume_white_min;
            if (volume_bar.Value >= 40 && volume_bar.Value < 90)
                volume_btn.Image = Properties.Resources.volume_white_normal;
            if (volume_bar.Value >= 90 && volume_bar.Value < 101)
                volume_btn.Image = Properties.Resources.volume_white_max;
        }

        private void ToVolGray()
        {
            if (volume_bar.Value < 1)
                volume_btn.Image = Properties.Resources.volume_gray_no;
            if (volume_bar.Value < 40 && volume_bar.Value > 2)
                volume_btn.Image = Properties.Resources.volume_gray_min;
            if (volume_bar.Value >= 40 && volume_bar.Value < 90)
                volume_btn.Image = Properties.Resources.volume_gray_normal;
            if (volume_bar.Value >= 90 && volume_bar.Value < 101)
                volume_btn.Image = Properties.Resources.volume_gray_max;
        }

        private void Volume_btn_MouseLeave(object sender, EventArgs e)
        {
            ToVolGray();
            volume_btn.Refresh();
        }

        private void Volume_btn_MouseEnter(object sender, EventArgs e)
        {
            ToVolWhite();
            volume_btn.Refresh();
        }

        private bool flg = true;
        private void Volume_btn_Click(object sender, EventArgs e)
        {
            if (flg)
            {
                volume_bar.Value = 0;
                flg = false;
                volume_btn.Image = Properties.Resources.volume_white_no;
            }
            else
            {
                volume_bar.Value = 100;
                flg = true;
                volume_btn.Image = Properties.Resources.volume_white_max;
            }
            volume_btn.Refresh();
            BassCore.SetVolumeToStream(BassCore.Stream, volume_bar.Value);
        }

        private void Recent_plays_Click(object sender, EventArgs e)
        {
            music_list.Hide();
            //TODO Recent_plays Click Handler
        }

        private void Now_playing_Click(object sender, EventArgs e)
        {
            music_list.Hide();
            //TODO Now_playing_Click Handler
        }

        private void Plus_btn_Click(object sender, EventArgs e)
        {
            if (!account.IsAuthorized)
            {
                file_open.Filter = Properties.Resources.MusicFormatString;
                if (file_open.ShowDialog() == DialogResult.OK)
                {
                    string fName = $"{ Properties.Resources.PublicMusicFolder}{ Path.GetFileNameWithoutExtension(file_open.FileName)}{Path.GetExtension(file_open.FileName)}";
                    if (!File.Exists(fName))
                        File.Copy(file_open.FileName, fName);
                    var item = new Music_Item();
                    item.Name = Path.GetFileNameWithoutExtension(file_open.FileName);
                    item.ArtistName = Properties.Resources.UnknownMusicArtist;
                    if (!closed)
                        item.Size = new Size(music_list.Size.Width - 26, item.Size.Height);
                    else
                        item.Size = new Size(music_list.Size.Width - 493, item.Size.Height);
                    item.MouseClick += Item_MouseClick;
                    music_list.Controls.Add(item);
                    item.Index = music_list.Controls.IndexOf(item);
                    music_list.Controls.Add(item);
                    music_list.Show();
                    random_play_btn.Enabled = true;
                    left_arrow_btn.Enabled = true;
                    play_btn.Enabled = true;
                    replay_btn.Enabled = true;
                    volume_btn.Enabled = true;
                    right_arrow_btn.Enabled = true;
                }
            }
            else
            {
                MusicMessageBox box = new MusicMessageBox();
                box.ShowWindow(this, Properties.Resources.NeedToLogOutMessage);
                box.Show();
            }
        }

        private PlayerActions action = PlayerActions.Noting;

        private bool random = false;
        private void Random_play_btn_Click(object sender, EventArgs e)
        {
            if (random)
            {
                action = PlayerActions.Noting;
                replay_btn.Enabled = true;
                ((Button)sender).MouseLeave += Random_Play_btn_MouseLeave;
                random = false;
            }
            else
            {
                action = PlayerActions.RandomPlay;
                replay_btn.Enabled = false;
                random = true;
                ((Button)sender).MouseLeave -= Random_Play_btn_MouseLeave;
                ((Button)sender).Image = Properties.Resources.random_white;
                ((Button)sender).Refresh();
            }
        }

        private bool replayAgain = false;
        private void Replay_btn_Click(object sender, EventArgs e)
        {
            if (replayAgain)
            {
                action = PlayerActions.Noting;
                random_play_btn.Enabled = true;
                ((Button)sender).MouseLeave += Replay_btn_MouseLeave;
                replayAgain = false;
            }
            else
            {
                action = PlayerActions.RePlay;
                random_play_btn.Enabled = false;
                replayAgain = true;
                ((Button)sender).MouseLeave -= Replay_btn_MouseLeave;
                ((Button)sender).Image = Properties.Resources.replay_white;
                ((Button)sender).Refresh();
            }
        }

        private void Right_arrow_btn_MouseDown(object sender, MouseEventArgs e)
        {
            BassCore.SetChannelPosition(BassCore.Stream, music_Track_Bar.Value += 5);
        }

        private void Left_arrow_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (music_Track_Bar.Value - 5 <= 0)
                BassCore.SetChannelPosition(BassCore.Stream, 0);
            else
                BassCore.SetChannelPosition(BassCore.Stream, music_Track_Bar.Value -= 5);
        }

        private void Up_Menu_btn_MouseEnter(object sender, EventArgs e)
        {
            light_panel2.Show();
            light_panel2.Location = new Point(((Button)sender).Location.X, light_panel2.Location.Y);
            for (int i = 0; i < 165; i += 2)
            {
                light_panel2.Size = new Size(i, 5);
                ((Button)sender).Refresh();
            }
        }

        private void Up_Menu_btn_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 165; i > 0; i -= 2)
            {
                light_panel2.Size = new Size(i, 5);
                ((Button)sender).Refresh();
            }
        }

        private void settings_btn_MouseEnter(object sender, EventArgs e)
        {
            Button b = ((Button)sender);
            b.Image = Properties.Resources.setting_purp.ToBitmap();
            b.BackColor = Color.FromArgb(63, 60, 65);
            b.Refresh();
        }

        private void settings_btn_MouseLeave(object sender, EventArgs e)
        {
            Button b = ((Button)sender);
            b.Image = Properties.Resources.settings_white.ToBitmap();
            b.BackColor = Color.Black;
            b.Refresh();
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            SettingForm s = new SettingForm(this);
            s.Show();
            this.Hide();
        }
    }
}
