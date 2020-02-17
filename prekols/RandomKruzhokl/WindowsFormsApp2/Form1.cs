using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        Rectangle rec = new Rectangle(10, 10, 50, 50);
        SolidBrush s = new SolidBrush(Color.Pink);
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

      }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rec.X = r.Next(-30, pictureBox1.Width);
            rec.Y = r.Next(-30, pictureBox1.Height);
          //  rec.Width = r.Next(pictureBox1.Width/20, pictureBox1.Width/10);
          //  rec.Height = rec.Width;
            s.Color = Color.Yellow;
          //  s.Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            g.FillEllipse(s, rec);
            timer1.Interval = r.Next(100, 1000);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Size = Size;
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        
    }
}
