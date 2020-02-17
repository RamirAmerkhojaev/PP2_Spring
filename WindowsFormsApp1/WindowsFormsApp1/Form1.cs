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
        Random rand = new Random();
        List<Rectangle> circles;


        public Form1()
        {
            circles = new List<Rectangle>();
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Size size = new Size(50, 50);
            SolidBrush b = new SolidBrush(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
            Rectangle rectangle = new Rectangle(rand.Next(0, 550), rand.Next(25, 25), 50, 50);
            graphics.FillEllipse(b, rectangle);
            circles.Add(rectangle);
            pictureBox1.Refresh();

            graphics.Clear(Color.White);
       
            for (int i = 0; i < circles.Count; i++)
            {
                Rectangle circle = circles[i];
                graphics.FillEllipse(b, circle);
                circle.Y = circle.Y + 20;
                circles[i] = circle;
                if(circle.Y > pictureBox1.Height- 41)
                {
                    timer1.Stop();
                }
            }

            pictureBox1.Refresh();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();      
        }
    }
}
