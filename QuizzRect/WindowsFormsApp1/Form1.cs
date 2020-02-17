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

        enum Dir
        {
            up,
            right,
            down,
            left
        }

        Graphics graphics;
        Pen pen;
        Point p;
        Rectangle rectangle;
        Size size;

        Dir dir_move = Dir.down;

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 10);
            graphics = pictureBox1.CreateGraphics();
            size = new Size(50, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dir_move = Dir.up;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dir_move = Dir.left;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dir_move = Dir.right;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dir_move = Dir.down;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p.X = int.Parse(textBox1.Text);
            p.Y = int.Parse(textBox1.Text);
            rectangle = new Rectangle(p, size);
            graphics.DrawEllipse(pen, rectangle);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (dir_move)
            {
                case Dir.up:

                    rectangle.Y -= 10;
                    graphics.Clear(Color.White);
                    pen.Color = Color.CadetBlue;
                    graphics.DrawEllipse(pen, rectangle);
                    break;
                case Dir.right:

                    rectangle.X += 10;
                    graphics.Clear(Color.White);
                    pen.Color = Color.Black;
                    graphics.DrawEllipse(pen, rectangle);
                    break;
                case Dir.down:

                    rectangle.Y += 10;
                    graphics.Clear(Color.White);
                    pen.Color = Color.ForestGreen;
                    graphics.DrawEllipse(pen, rectangle);
                    break;
                case Dir.left:

                    rectangle.X -= 10;
                    graphics.Clear(Color.White);
                    pen.Color = Color.LightGray;
                    graphics.DrawEllipse(pen, rectangle);
                    break;
            }
        }
    }
}
