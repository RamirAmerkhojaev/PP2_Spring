using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    enum Tool
    {
        Pen,
        Line,
        Rectangle,
        Circle,
        Star,
        Triangle,
        Fill
    }

    public partial class Form1 : Form
    {
        Graphics graphics;
        Bitmap bitmap;
        Point firstpint;
        Point secondpoint;
        Pen pen = new Pen(Color.Red, 2);
        Tool activetool = Tool.Pen;
        SolidBrush brush = new SolidBrush(Color.Red);
        
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox2.Image = bitmap;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Penbtn_Click(object sender, EventArgs e)
        {
            activetool = Tool.Pen;
        }
        private void Linebtn_Click(object sender, EventArgs e)
        {
            activetool = Tool.Line;
        }

        private void Rectanglebtn_Click(object sender, EventArgs e)
        {
            activetool = Tool.Rectangle;
        }

        private void Trianglebtn_Click(object sender, EventArgs e)
        {
            activetool = Tool.Triangle;
        }

        private void Circlebtn_Click(object sender, EventArgs e)
        {
            activetool = Tool.Circle;
        }

        private void Starbtn_Click(object sender, EventArgs e)
        {
            activetool = Tool.Star;
        }

        private void Fillbtn_Click(object sender, EventArgs e)
        {
            activetool = Tool.Fill;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {                
                secondpoint = e.Location;
                switch (activetool)
                {
                    case Tool.Pen:
                        graphics.DrawLine(pen, firstpint, secondpoint);
                        pen.Width = trackBar1.Value;
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        firstpint = secondpoint;
                        break;
                    case Tool.Line:
                        break;
                    case Tool.Rectangle:
                        break;
                    case Tool.Triangle:
                        break;
                    case Tool.Circle:
                        break;
                    case Tool.Star:
                        break;
                    case Tool.Fill:
                        break;
                    default:
                        break;
                }
                pictureBox2.Refresh();
            }
        }

        

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            switch (activetool)
            {
                case Tool.Pen:                 
                    break;
                case Tool.Line:
                    secondpoint = e.Location;
                    graphics.DrawLine(pen, firstpint, secondpoint);
                    pictureBox2.Refresh();
                    break;
                case Tool.Rectangle:
                    secondpoint = e.Location;
                    graphics.DrawRectangle(pen, GetRectangle(firstpint, secondpoint));
                    pictureBox2.Refresh();                    
                    break;
                case Tool.Triangle:
                    secondpoint = e.Location;
                    graphics.DrawPolygon(pen, GetTriangle(firstpint, secondpoint));
                    pictureBox2.Refresh();
                    break;
                case Tool.Circle:
                    secondpoint = e.Location;
                    graphics.DrawEllipse(pen, GetRectangle(firstpint, secondpoint));
                    pictureBox2.Refresh();
                    break;
                case Tool.Star:
                    secondpoint = e.Location;
                    graphics.DrawPolygon(pen, Zvezda5(firstpint, secondpoint));
                    pictureBox2.Refresh();
                    break;
                case Tool.Fill:
                    break;
                default:
                    break;
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            switch (activetool)
            {
                case Tool.Pen:
                    break;
                case Tool.Line:
                    e.Graphics.DrawLine(pen, firstpint, secondpoint);
                    break;
                case Tool.Rectangle:
                    e.Graphics.DrawRectangle(pen, GetRectangle(firstpint, secondpoint));
                    break;
                case Tool.Triangle:
                    e.Graphics.DrawPolygon(pen, GetTriangle(firstpint, secondpoint));
                    break;
                case Tool.Circle:
                    e.Graphics.DrawEllipse(pen, GetRectangle(firstpint, secondpoint));
                    break;
                case Tool.Star:
                    e.Graphics.DrawPolygon(pen, Zvezda5(firstpint, secondpoint));
                    break;
                case Tool.Fill:
                    break;
                default:
                    break;
            }
        }
   

        Rectangle GetRectangle(Point p1, Point p2)
        {
            Rectangle res = new Rectangle();
            res.X = Math.Min(p1.X, p2.X);
            res.Y = Math.Min(p1.Y, p2.Y);
            res.Width = Math.Abs(p1.X - p2.X);
            res.Height = Math.Abs(p1.Y - p2.Y);                     

            return res;
        }

        public Point[] GetTriangle(Point a, Point b)
        {

            List<Point> list2 = new List<Point>();            
            int width = b.X - a.X;
            int height = b.Y - a.Y;
            list2.Add(new Point(a.X, a.Y));
            list2.Add(new Point(a.X - width, a.Y + height));
            list2.Add(new Point(b.X, b.Y));
            return list2.ToArray();
        }

        public Point[] Zvezda5(Point a, Point b)
        {
            List<Point> list = new List<Point>();
            int width = b.X - a.X;
            int height = b.Y - a.Y;
            list.Add(new Point(a.X + width / 2, a.Y));
            list.Add(new Point(a.X + (width / 5) * 3, a.Y + (height / 5) * 2));
            list.Add(new Point(b.X, a.Y + (height / 5) * 2));
            list.Add(new Point(a.X + (width / 3) * 2, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X + (width / 5) * 4, b.Y));
            list.Add(new Point(a.X + width / 2, a.Y + (height / 5) * 4));
            list.Add(new Point(a.X + width / 5, b.Y));
            list.Add(new Point(a.X + width / 3, a.Y + (height / 5) * 3));
            list.Add(new Point(a.X, a.Y + (height / 5) * 2));
            list.Add(new Point(a.X + (width / 5) * 2, a.Y + (height / 5) * 2));
            return list.ToArray();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            firstpint = e.Location;

            if(activetool == Tool.Fill)
            {
                DummyFill dummyFill = new DummyFill();
                dummyFill.Fill(bitmap, e.Location, pen.Color);
                
            }
            pictureBox2.Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox2.Refresh();    
            
        }

       

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void rubberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;    
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
       
            saveFileDialog1.ShowDialog();
            bitmap.Save(saveFileDialog1.FileName);
         
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            bitmap = new Bitmap(openFileDialog1.FileName);
            graphics = Graphics.FromImage(bitmap);
            pictureBox2.Image = bitmap;
            pictureBox2.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
