using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLiteConnection conn;

        public DataTable GetDataForTable(string tablename)
        {
            conn = new SQLiteConnection("Data Source = C:/Users/Dell/Downloads/northwindEF.db");
            DataTable dataTable = new DataTable();
            conn.Open();
            
            string sql = string.Format("SELECT * FROM {0}", tablename);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, conn);
            dataAdapter.Fill(dataTable);
            conn.Close();

            return dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDataForTable("Audan");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDataForTable(comboBox1.Text);
        }
    }
}
