using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        List<Point> list = new List<Point>();
        List<Point> list2 = new List<Point>();
        Brush b = Brushes.Green;
     
        public static int cnt = 0;

        public Form1()
        {
           InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            list.Add(new Point(50,25));
            list.Add(new Point(15, 75));
            list.Add(new Point(85,75));
            list2.Add(new Point(15, 45));
            list2.Add(new Point(85, 45));
            list2.Add(new Point(50, 95));


            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {

            graphics.Clear(Color.White);
            Point[] asdf = list.ToArray();
            Point[] asdf2 = list2.ToArray();
            for (int i=0; i<3; i++)
            {
                asdf[i].X += 10;
       
            }
            for (int j = 0; j < 3; j++)
            {
                asdf2[j].X += 10;
            }

      

            graphics.FillPolygon(b, asdf.ToArray());
            graphics.FillPolygon(b, asdf2.ToArray());
            list.Clear();
            list2.Clear();
            list.AddRange(asdf);
            list2.AddRange(asdf2);
            pictureBox1.Refresh();

        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            timer1.Start();
        }
    }
}
