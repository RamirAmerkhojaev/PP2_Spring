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
        Random ran = new Random();     

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();             
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            Size size = new Size(50, 50);
            Size size2 = new Size(100, 100);
            SolidBrush b = new SolidBrush(Color.FromArgb(ran.Next(256), ran.Next(256), ran.Next(256)));
            Rectangle rectangle = new Rectangle(ran.Next(0, 800), ran.Next(0, 400), 50, 50);
            graphics.FillEllipse(b, rectangle);
            pictureBox1.Refresh();
        }
    }
}
