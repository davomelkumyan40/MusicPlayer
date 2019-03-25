using System;
using System.Drawing;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Music_Item : UserControl
    {
        public Music_Item()
        {
            InitializeComponent();
            Index = -1;
        }

        public string ArtistName { get => executor_name.Text; set => executor_name.Text = value; }
        public new string Name { get => music_name.Text; set => music_name.Text = value; }
        public Color NameForColor { get => music_name.ForeColor; set => music_name.ForeColor = value; }
        public Color ExForColor { get => executor_name.ForeColor; set => executor_name.ForeColor = value; }
        public PictureBox Play { get => play_btn; }
        public string MB { get => music_size.Text; }
        public int Index { get; set; }

        private void Play_btn_MouseEnter(object sender, EventArgs e)
        {
            Play.Image = Properties.Resources.playmini_purple;
        }

        private void Play_btn_MouseLeave(object sender, EventArgs e)
        {
            Play.Image = Properties.Resources.playmini_gray;
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
