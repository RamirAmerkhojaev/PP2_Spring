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

        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
   
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (button2.BackColor == Color.Black || button4.BackColor == Color.Black
                || button6.BackColor == Color.Black || button8.BackColor == Color.Black)
            {
                button2.BackColor = Color.White;
                button4.BackColor = Color.White;
                button6.BackColor = Color.White;
                button8.BackColor = Color.White;
            }
            else
            {
                button2.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button6.BackColor = Color.Black;
                button8.BackColor = Color.Black;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button5.Location = new Point(button5.Location.X - 5, button5.Location.Y-5);
            button3.Location = new Point(button3.Location.X + 5, button5.Location.Y-5);
            button7.Location = new Point(button7.Location.X - 5, button7.Location.Y+5);
            button9.Location = new Point(button9.Location.X + 5, button9.Location.Y+5);
            button1.BackColor = Color.FromArgb(ran.Next(256), ran.Next(256), ran.Next(256));
        }

        
    }
}
