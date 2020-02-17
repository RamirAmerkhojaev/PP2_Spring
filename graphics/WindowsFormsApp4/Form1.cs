using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Yellow);
            SolidBrush solidBrush2 = new SolidBrush(Color.Green);
            SolidBrush solidBrush3 = new SolidBrush(Color.Red);
            SolidBrush circle = new SolidBrush(Color.White);

            Rectangle rectangle = new Rectangle(300, 200, 100, 50);
            Rectangle vector = new Rectangle(340, 215, 20, 40);
            Rectangle star = new Rectangle(340, 75, 20, 20);

            PointF star4 = new PointF(350.0F, 25.0F);
            PointF star5 = new PointF(340.0F, 75.0F);
            PointF star6 = new PointF(360.0F, 75.0F);


            PointF[] curvePoints5 =
                   {
               star4,
               star5,
               star6,

             };

            PointF star1 = new PointF(360.0F, 75.0F);
            PointF star2 = new PointF(410.0F, 85.0F);
            PointF star3 = new PointF(360.0F, 95.0F);

            PointF[] curvePoints4 =
                   {
               star1,
               star2,
               star3,

             };

            PointF star7 = new PointF(360.0F, 95.0F);
            PointF star8 = new PointF(350.0F, 145.0F);
            PointF star9 = new PointF(340.0F, 95.0F);

            PointF[] curvePoints6 =
                   {
               star7,
               star8,
               star9,

             };

            PointF star10 = new PointF(340.0F, 95.0F);
            PointF star11 = new PointF(290.0F, 85.0F);
            PointF star12 = new PointF(340.0F, 75.0F);

            PointF[] curvePoints7 =
                   {
               star10,
               star11,
               star12,

             };

            PointF vector1 = new PointF(350.0F, 190.0F);
            PointF vector2 = new PointF(325.0F, 215.0F);
            PointF vector3 = new PointF(375.0F, 215.0F);


            PointF[] curvePoints3 =
                     {
                 vector1,
                 vector2,
                 vector3,
             };

            PointF yellow4 = new PointF(300.0F, 250.0F);
            PointF yellow5 = new PointF(400.0F, 250.0F);
            PointF yellow6 = new PointF(350.0F, 280.0F);


            PointF[] curvePoints2 =
                     {
                 yellow4,
                 yellow5,
                 yellow6,
             };

            PointF yellow1 = new PointF(350.0F, 170.0F);
            PointF yellow2 = new PointF(300.0F, 200.0F);
            PointF yellow3 = new PointF(400.0F, 200.0F);


            PointF[] curvePoints1 =
                     {
                 yellow1,
                 yellow2,
                 yellow3,
             };

            PointF captain1 = new PointF(330.0F, 350.0F);
            PointF captain2 = new PointF(370.0F, 410.0F);
            PointF captain3 = new PointF(290.0F, 410.0F);

            PointF[] curvePoints8 =
                   {
               captain1,
               captain2,
               captain3,

             };

            PointF captain4 = new PointF(370.0F, 375.0F);
            PointF captain5 = new PointF(290.0F, 375.0F);
            PointF captain6 = new PointF(330.0F, 435.0F);

            PointF[] curvePoints9 =
                   {
               captain4,
               captain5,
               captain6,

             };
            PointF vietnam1 = new PointF(570.0F, 210.0F);
            PointF vietnam2 = new PointF(610.0F, 270.0F);
            PointF vietnam3 = new PointF(530.0F, 270.0F);

            PointF[] curvePoints10 =
                   {
               vietnam1,
               vietnam2,
               vietnam3,

             };
            PointF vietnam4 = new PointF(530.0F, 235.0F);
            PointF vietnam5 = new PointF(610.0F, 235.0F);
            PointF vietnam6 = new PointF(570.0F, 295.0F);

            PointF[] curvePoints11 =
                   {
               vietnam4,
               vietnam5,
               vietnam6,

             };

            e.Graphics.FillPolygon(solidBrush, curvePoints2);
            e.Graphics.FillPolygon(solidBrush, curvePoints1);
            e.Graphics.FillRectangle(solidBrush, rectangle);
            e.Graphics.FillRectangle(solidBrush2, vector);
            e.Graphics.FillPolygon(solidBrush2, curvePoints3);
            e.Graphics.FillEllipse(circle, 50, 50, 50, 50);
            e.Graphics.FillEllipse(circle, 100, 300, 50, 50);
            e.Graphics.FillEllipse(circle, 500, 50, 50, 50);
            e.Graphics.FillEllipse(circle, 600, 400, 50, 50);
            e.Graphics.FillPolygon(solidBrush2, curvePoints4);
            e.Graphics.FillPolygon(solidBrush2, curvePoints5);
            e.Graphics.FillPolygon(solidBrush2, curvePoints6);
            e.Graphics.FillPolygon(solidBrush2, curvePoints7);
            e.Graphics.FillRectangle(solidBrush2, star);
            e.Graphics.FillPolygon(solidBrush3, curvePoints8);
            e.Graphics.FillPolygon(solidBrush3, curvePoints9);
            e.Graphics.FillPolygon(solidBrush3, curvePoints10);
            e.Graphics.FillPolygon(solidBrush3, curvePoints11);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
