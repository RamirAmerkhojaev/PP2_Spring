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
        Bitmap bitmap;
        Graphics graphics;
        List<Rectangle> circles;
        List<Brushes> brush;
        Brush b = Brushes.Red;
        Point p;
        Point p2;

        public Form1()
        {
            circles = new List<Rectangle>();
            brush = new List<Brushes>();
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }       

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            for(int i=0; i<circles.Count; i++)
            {
                Rectangle circle = circles[i];
                graphics.FillEllipse(b, circle);
                circle.Y = circle.Y + 20;
                circles[i] = circle;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {            
            pictureBox1.Refresh();
            timer1.Start();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Size size = new Size(50, 50);
            p2 = e.Location;
            graphics.FillEllipse(b, new Rectangle(p2, size));
            circles.Add(new Rectangle(p2, size));
            pictureBox1.Refresh();
        }
    }
}
