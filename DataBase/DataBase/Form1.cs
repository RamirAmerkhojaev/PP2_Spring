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

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.GetInstance.GetDataForTable("Customers");           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            if (newCustomer.ShowDialog() == DialogResult.OK)
            {
                Customer customer = new Customer
                {
                    CustomerID = newCustomer.textBox1.Text,
                    CompanyName = newCustomer.textBox2.Text,
                    ContactName = newCustomer.textBox3.Text,
                    Address = newCustomer.textBox4.Text,
                    City = newCustomer.textBox5.Text,
                    PostalCode = newCustomer.textBox6.Text,
                    Country = newCustomer.textBox7.Text
                };

                DAL.GetInstance.InsertNewCustomer(customer);             

            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL.GetInstance.GetDataForTable(comboBox1.Text);
        }

      
    }
}
