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
        Bitmap bitmap;
        Graphics graphics;
        Pen pen1 = new Pen(Color.Black);
        Pen pen2 = new Pen(Color.Red);
        Pen pen3 = new Pen(Color.Green);
        Pen pen4 = new Pen(Color.Blue);
        List<PointF> points2;
        List<PointF> points1;
        List<PointF> points3;
        List<PointF> points4;


        float f2(double x)
        {
            double res = Math.Sin(( x * 180 )/ Math.PI);
            return (float)res;
        }
        float f1(float x)
        {
            return -x;
        }
        float f3(double x)
        {
            double res = Math.Sin((x * 180) / Math.PI) - 3.35 * x;
            return (float)res;
        }

        float f4(double x)
        {
            double res = Math.Sin((x * 180) / Math.PI) * 3 * x;
            return (float)res;
        }

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;

            points3 = new List<PointF>();
            for (double i = -12 * Math.PI; i <= -1* Math.PI; i = i + 0.1f)
            {
                float x = (float)i * 100 + Width / 2;
                float y = f3(i) * 30 + Height / 2;
                points3.Add(new PointF(x, y));
            }

            points4 = new List<PointF>();
            for (double i = -5.5 * Math.PI; i <= -1 * Math.PI; i = i + 0.1f)
            {
                float x = (float)i * 75 + Width / 2;
                float y = f4(i) * 10 + Height / 2;
                points4.Add(new PointF(x, y));
            }


            points1 = new List<PointF>();
            for (float i = -2 * Width; i <= -Width / 2; i = i + 0.5f)
            {
                float x = i + Width / 2;
                float y = f1(i) + Height / 2;
                points1.Add(new PointF(x, y));
            }

            points2 = new List<PointF>();
            for (double i = -12 * Math.PI; i <= -1 * Math.PI; i = i + 0.1f)
            {
                float x = (float)i * 85 + Width / 2;
                float y = f2(i) * 25 + Height / 2;
                points2.Add(new PointF(x, y));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            PointF[] asd1 = points1.ToArray();
            PointF[] asd = points2.ToArray();
            PointF[] asd2 = points3.ToArray();
            PointF[] asd3 = points4.ToArray();
          
            for(int j = 0; j< points1.Count; j++)
            {
                asd1[j].X += 11;
                asd1[j].Y -= 11;
                if(asd1[j].X > pictureBox1.Width && asd1[j].Y > pictureBox1.Height)
                {
                    timer1.Stop();
                }
            }

            for (int i = 0; i < points4.Count; i++)
            {
                asd3[i].X += 4;
                if (asd3[i].X > pictureBox1.Width / 2)
                {
                    timer1.Stop();
                }
            }

            for (int i=0; i<points3.Count; i++)
            {
                asd2[i].X += 11;
                asd2[i].Y -= 11;
                if (asd2[i].X > pictureBox1.Width && asd2[i].Y > pictureBox1.Height)
                {
                    timer1.Stop();
                }
            }

            for (int i = 0; i < points2.Count; i++)
            {
                asd[i].X += 10;
                if(asd[i].X > pictureBox1.Width)
                {
                    timer1.Stop();
                }
            }

            graphics.DrawLines(pen3, asd1.ToArray());
            graphics.DrawCurve(pen2, asd.ToArray());
            graphics.DrawCurve(pen4, asd2.ToArray());
            graphics.DrawCurve(pen4, asd3.ToArray());
            points1.Clear();
            points2.Clear();
            points3.Clear();
            points4.Clear();
            points1.AddRange(asd1);
            points2.AddRange(asd);
            points3.AddRange(asd2);
            points4.AddRange(asd3);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen1, Width / 2, 0, Width / 2, Height);
            e.Graphics.DrawLine(pen1, 0, Height/2, Width, Height/2);
        }
    }
}
