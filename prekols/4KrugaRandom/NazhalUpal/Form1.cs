using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NazhalUpal
{
    public partial class Form1 : Form
    {
        Graphics g;
        Random r = new Random();
        Pen p = new Pen(Color.Red, 2);
        List<Rectangle> rs1 = new List<Rectangle>();
        List<Rectangle> rs2 = new List<Rectangle>();
        List<Rectangle> rs3 = new List<Rectangle>();
        List<Rectangle> rs4 = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            foreach (Rectangle r in rs1)
            {
                g.DrawEllipse(p, r);
            }
            foreach (Rectangle r in rs2)
            {
                g.DrawEllipse(p, r);
            }
            foreach (Rectangle r in rs3)
            {
                g.DrawEllipse(p, r);
            }
            foreach (Rectangle r in rs4)
            {
                g.FillEllipse(p.Brush, r);
            }
            Rectangle[] rsp1 = rs1.ToArray();
            Rectangle[] rsp2 = rs2.ToArray();
            Rectangle[] rsp3 = rs3.ToArray();
            Rectangle[] rsp4 = rs4.ToArray();
            for (int i = 0; i < rsp1.Length; i++)
            {
                rsp1[i].Y += 5;

                if (rsp1[i].Y > pictureBox1.Height)
                {
                    rsp1[i].Y = 0;
                }
            }
            rs1.Clear();
            rs1.AddRange(rsp1);
            for (int i = 0; i < rsp2.Length; i++)
            {
                rsp2[i].Y -= 5;

                if (rsp2[i].Y > pictureBox1.Height)
                {
                    rsp2[i].Y = 0;
                }
            }
            rs2.Clear();
            rs2.AddRange(rsp2);

            for (int i = 0; i < rsp3.Length; i++)
            {
                rsp3[i].X -= 5;

                if (rsp3[i].X > pictureBox1.Width)
                {
                    rsp3[i].X = 0;
                }
            }
            rs3.Clear();
            rs3.AddRange(rsp3);

            for (int i = 0; i < rsp4.Length; i++)
            {
                rsp4[i].X += 5;

                if (rsp4[i].X > pictureBox1.Width)
                {
                    rsp4[i].X = 0;
                }
            }
            rs4.Clear();
            rs4.AddRange(rsp4);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            p.Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            int asd = r.Next(1);
            asd = 1;
            if (asd == 1) rs1.Add(new Rectangle(e.X, e.Y, 50, 50));
            else if (asd == 2) rs2.Add(new Rectangle(e.X, e.Y, 50, 50));
            else if (asd == 3) rs3.Add(new Rectangle(e.X, e.Y, 50, 50));
            else if (asd == 4) rs4.Add(new Rectangle(e.X, e.Y, 50, 50));
        }
    }
}
