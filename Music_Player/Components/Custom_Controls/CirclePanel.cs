using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Music_Player.Components.Custom_Controls
{
    class CirclePanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath graph = new GraphicsPath();
            graph.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graph);
            base.OnPaint(e);
        }
    }
}
