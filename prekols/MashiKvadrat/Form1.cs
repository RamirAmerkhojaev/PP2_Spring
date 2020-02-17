using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MashiKvadrat
{
    public partial class Form1 : Form
    {
        Graphics g;
        int d;
        Rectangle r;
        Pen p;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            p = new Pen(Color.Red);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            g.DrawRectangle(p, r);
            r.X += d;
            if (r.X + 50 > Width || r.X < 0)
                d *= -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = new Rectangle(20, 20, 50, 50);
            d = 5;
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int znak = (d / Math.Abs(d));
            d = znak * (Math.Abs(d) - 5);
            if (d == 0)
                d = znak * 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int znak = (d / Math.Abs(d));
            d = znak * (Math.Abs(d) + 5);
            if (d == 0)
                d = znak * 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d *= -1;
        }
    }
}
