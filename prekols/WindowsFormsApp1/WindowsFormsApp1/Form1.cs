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

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Button> ls = new List<Button>();
            Color[] a = { Color.Red, Color.White, Color.Yellow, Color.Blue};
            int x = 0, y = 0;
            for(int i =0; i<4; i++)
            {
                Button b = new Button();
                b.Top = x;
                b.Left = y;
                b.BackColor = a[i];
                Button b1 = b;
                b1.Left += 50;
                x += 20;
                if(x > 80)
                {
                    x = 0;
                    y += 20;
                }
                ls.Add(b);
                ls.Add(b1);
                Controls.Add(b);
                Controls.Add(b1);
            }
        }
    }
}
