using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartoxaSMyasom
{
    public partial class Form1 : Form
    {
        public Graphics g;
        Rectangle r1, r2;
        int d = 5;
        Pen p = new Pen(Color.Red);
        int width;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            width = r.Next(50, 100);
            r1 = new Rectangle(0, 0, width, width);
            r2 = new Rectangle(pictureBox1.Width - width, 0, width, width);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            g.DrawRectangle(p, r1);
            g.DrawRectangle(p, r2);
            if (r1.X + width >= r2.X)
                d *= -1;
            else if (r1.X < 0)
                d *= -1;
            r1.X += d;
            r2.X -= d;
        }
    }
}
