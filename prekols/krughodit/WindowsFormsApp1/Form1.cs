using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Red, 3);
        int x, y;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(p, new Rectangle(x, y, 50, 50));
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                pictureBox1.Refresh();
            }
        }
    }
}
