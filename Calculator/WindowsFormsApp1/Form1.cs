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

      

        double a, b, c, n;
        char ch = '+';
    

        private void button2_Click(object sender, EventArgs e)
        {           

            b = Convert.ToDouble(textBox1.Text);
            switch (ch)
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;              
            }
            textBox1.Text = c.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
          
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = "-" + textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = a / 100;
            textBox1.Text = c.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = Math.Sqrt(a);
            textBox1.Text = c.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = a * a;
            textBox1.Text = c.ToString();
        }

      
        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);

            c = Math.Sin(a);
            textBox1.Text = c.ToString();
       
        }
 
        private void button3_Click(object sender, EventArgs e)
        { 
            a = Convert.ToDouble(textBox1.Text);
            ch = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
                      
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = 1/a;
            textBox1.Text = c.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = button.Text + textBox1.Text;

            if (textBox1.Text[0] == '0')
                textBox1.Text = button.Text;
        }
    }
}
