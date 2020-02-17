using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace ManiaKvadratov
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Red);
        Pen p1 = new Pen(Color.Green);
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            DirectoryInfo d = new DirectoryInfo(path);
            int kvad = d.GetFiles().Length;
            int krug = d.GetDirectories().Length;
            int x = 0, y = 0;
            for(int i =0; i<kvad; i++)
            {
                g.FillRectangle(p.Brush, x, y, 20, 20);
                Thread.Sleep(30);
                x += 25;
                if(x>pictureBox1.Width - 20)
                {
                    x = 0;
                    y += 30;
                }
            }
            x = 0; y = 0;
            for (int i = 0; i < krug; i++)
            {
                g.FillEllipse(p1.Brush, x, y, 20, 20);
                Thread.Sleep(30);
                x += 25;
                if (x > pictureBox1.Width - 20)
                {
                    x = 0;
                    y += 30;
                }
            }

        }
    }
}
