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
        public Form1()
        {
            InitializeComponent();
        }
        Pen pen1 = new Pen(Color.Black);
        Pen pen2 = new Pen(Color.Red);
        Pen pen3 = new Pen(Color.Green);
        Pen pen4 = new Pen(Color.Blue);
        Pen pen5 = new Pen(Color.Brown);

        float f1(float x)
        {
            return -x;
        }
        float f2(double x)
        {
            double res = Math.Sin(x * 180 / Math.PI);
            return (float)res;
        }

        float f3(double x)
        {
            double res = Math.Sin((x * 180 )/ Math.PI) - 3.5*x;
            return (float)res;
        }

        float f4(double x)
        {
            double res = Math.Sin((x * 180) / Math.PI) * 3 * x;
            return (float)res;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen1, Width / 2, 0, Width / 2, Height);
            e.Graphics.DrawLine(pen1, 0, Height / 2, Width, Height / 2);

            List<PointF> points1 = new List<PointF>();
            for (float i = -Width; i <= Width; i = i + 0.5f)
            {
                float x = i + Width / 2;
                float y = f1(i) + Height / 2;
                points1.Add(new PointF(x, y));
            }
            e.Graphics.DrawLines(pen2, points1.ToArray());

            List<PointF> points2 = new List<PointF>();
            for (double i = -12 * Math.PI; i <= 2 * Math.PI; i = i + 0.1f)
            {
                float x = (float)i * 75 + Width / 2;
                float y = f2(i) * 25 + Height / 2;
                points2.Add(new PointF(x, y));
            }
            e.Graphics.DrawLines(pen3, points2.ToArray());

            List<PointF> points3 = new List<PointF>();
            for (double i = -12 * Math.PI; i <= 2 * Math.PI; i = i + 0.1f)
            {
                float x = (float)i * 100 + Width / 2;
                float y = f3(i) * 30 + Height / 2;
                points3.Add(new PointF(x, y));
            }
            e.Graphics.DrawCurve(pen4, points3.ToArray());

            List<PointF> points4 = new List<PointF>();
            for (double i = -12 * Math.PI; i <=  Math.PI; i = i + 0.1f)
            {
                float x = (float)i * 100 + Width / 2;
                float y = f4(i) * 30 + Height / 2;
                points4.Add(new PointF(x, y));
            }
            e.Graphics.DrawCurve(pen5, points4.ToArray());
        }


    }
}
