using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PowerSources
{
    public partial class Form1 : Form
    {
  //      private Bitmap onScaled;
        public Form1()
        {
            InitializeComponent();
//            onScaled = new Bitmap(Properties.Resources.on);
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                float w = Properties.Resources.on.Width * 0.4f;
                float h = Properties.Resources.on.Height * 0.4f;
                gr.DrawImage(Properties.Resources.on, e.X - w / 2, e.Y - h / 2, w, h);
            }
            else
            {
                float w = Properties.Resources.off.Width * 0.4f;
                float h = Properties.Resources.off.Height * 0.4f;
                gr.DrawImage(Properties.Resources.off, e.X - w / 2, e.Y - h / 2, w, h);
            }
        }
    }
}
