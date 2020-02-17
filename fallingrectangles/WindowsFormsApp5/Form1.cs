using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        List<Rectangle> rectangles;
        List<Brush> brushes;
        Point point1;
        Point point2;
        Brush b = Brushes.Red;
        int cnt = 0;

        public Form1()
        {
            rectangles = new List<Rectangle>();
            brushes = new List<Brush>();
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);


            for (int i = 0; i < rectangles.Count; i++)
            {

                Rectangle rectangle = rectangles[i];
                graphics.FillRectangle(brushes[i], rectangle);
                rectangle.Y = rectangle.Y + 20;
                rectangles[i] = rectangle;

            }

            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            timer1.Start();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point1 = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            point2 = e.Location;
            int width = Math.Abs(point1.X - point2.X);
            int height = Math.Abs(point1.Y - point2.Y);
            Point p = new Point(Math.Min(point1.X, point2.X), Math.Min(point2.Y, point1.Y));
            graphics.FillRectangle(b, new Rectangle(p, new Size(width, height)));
            brushes.Add(b);
            rectangles.Add(new Rectangle(p, new Size(width, height)));      
            pictureBox1.Refresh();
            cnt++;
            if(cnt %3 == 0)
            {
                if (b == Brushes.Red)
                    b = Brushes.Black;
                else b = Brushes.Red;
            }         
        }
    }
}
