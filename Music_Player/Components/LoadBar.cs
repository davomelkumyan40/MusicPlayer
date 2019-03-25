using Music_Player.Components.Custom_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Music_Player.Components
{
    public partial class LoadBar : Form
    {
        public LoadBar()
        {
            InitializeComponent();
            SetRoundedShape(this, 60);
            loader.Start();
        }

        public LoadBar(string text)
            : this()
        {
            loading_text.Text = text;
        }

        //Rounded Controls
        private static void SetRoundedShape(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
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

        public Point TextPosition { get => loading_text.Location; set => loading_text.Location = value; }

        private List<CirclePanel> list;
        private static int index = 0;
        private static bool flag = true;
        private void loader_Tick(object sender, EventArgs e)
        {
            list = new List<CirclePanel>
            {
                load_item1, load_item2, load_item3, load_item4, load_item5, load_item6, load_item7, load_item8,
                load_item9, load_item10, load_item11, load_item12, load_item13, load_item14, load_item15
            };
            RoleLoadBetter();
        }

        private void RoleLoadBetter()
        {
            if (flag)
            {
                if (index == 15)
                {
                    list[index - 1].Size = new Size(10, 10);
                    index = 0;
                    flag = false;
                    return;
                }

                list[index].BackColor = Color.White;
                list[index].Size = new Size(16, 16);
                Refresh();
                if (index != 0)
                {
                    list[index - 1].Size = new Size(10, 10);
                }

                Refresh();
                index++;
            }
            else
            {
                if (index == 15)
                {
                    list[index - 1].Size = new Size(10, 10);
                    index = 0;
                    flag = true;
                    return;
                }

                list[index].BackColor = Color.FromArgb(136, 23, 152);
                list[index].Size = new Size(16, 16);
                Refresh();
                if (index != 0)
                {
                    list[index - 1].Size = new Size(10, 10);
                }

                Refresh();
                index++;
            }
        }

        private void RoleLoad()
        {
            if (index == 15)
            {
                list[index - 1].Size = new Size(10, 10);
                list[index - 1].BackColor = Color.FromArgb(136, 23, 152);
                index = 0;
            }

            list[index].BackColor = Color.White;
            list[index].Size = new Size(16, 16);
            Refresh();
            if (index != 0)
            {
                list[index - 1].Size = new Size(10, 10);
                list[index - 1].BackColor = Color.FromArgb(136, 23, 152);
            }

            Refresh();
            index++;
        }
    }
}
