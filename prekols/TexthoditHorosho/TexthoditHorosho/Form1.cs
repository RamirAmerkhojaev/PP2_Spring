using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexthoditHorosho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                textBox1.Location = e.Location;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
          {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
          }

        private void trackBar1_AutoSizeChanged(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
