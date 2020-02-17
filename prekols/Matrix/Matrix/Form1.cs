using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        List<char> s = new List<char>();
        int posx, posy;
        Graphics g;
        Pen p;
        Font f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            p = new Pen(Color.Green, 2);
            posy = posy = 0;
            f = DefaultFont;
            Random r = new Random(DateTime.Now.Millisecond);
            for(int i =0; i<pictureBox1.Width/10; i++)
            {
                int asd = r.Next(150);
                s.Add((char)asd);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            posx = 0;
            
            for(int i =0; i< s.Count; i++)
            {
                g.DrawString(s[i].ToString(), f, p.Brush, posx, posy);
                posx += 10;
            }
            posy += 15;
        }
    }
}
