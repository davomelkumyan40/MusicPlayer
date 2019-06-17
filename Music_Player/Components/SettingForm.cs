using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player.Components
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        public SettingForm(Player p)
        {
            InitializeComponent();
            this.BPlayer = p;
        }

        Player BPlayer { get; set; }

        private void button6_Click(object sender, EventArgs e)
        {
            if (BPlayer != null)
                BPlayer.Show();
            this.Close();
        }
    }
}
