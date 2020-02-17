using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBaza
{
    public partial class Form1 : Form
    {
        Dosje infa = new Dosje();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresher();
        }

        private void Refresher()
        {
            //infa = new Dosje();
            TelikIzAeroporta.DataSource = infa.DaiInfu();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Refresher();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(Klikuha.Text != "" && Klikuha.Text != "Klikuha")
            {
                infa.Vypolnyaj("insert into Bratki(Klikuha, TrueName, Ataman, Baba, Tachila, Puha) values('" + 
                    Klikuha.Text + "', '" + TrueName.Text + "', '" + 
                    Ataman.Checked + "', '" + Baba.Text + "', '" +
                    Tachila.Text + "', '" + Puha.Text + "');");
            }
            else
            {
                MessageBox.Show("Введите имя");
            }
            Refresher();
        }

        private void TelikIzAeroporta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var id = TelikIzAeroporta.CurrentRow.Cells[0].Value;
            var zhertva = TelikIzAeroporta.CurrentCell.Value;
            var column = TelikIzAeroporta.CurrentCell.OwningColumn.Name;
            string ukaz = "UPDATE Bratki SET " + column + "='" + zhertva + "' WHERE rowid=" + id;
            infa.Vypolnyaj(ukaz);
            Refresher();
        }

        private void TelikIzAeroporta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TelikIzAeroporta.BeginEdit(true);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var id = TelikIzAeroporta.CurrentRow.Cells[0].Value;
            infa.Vypolnyaj("Delete From Bratki Where rowid = " + id);
            Refresher();
        }
    }
}
