using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace balaji_b2
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\balaji46.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into product(cname,cgen,cmob,cemail,ccity) values('" + textBox1.Text + "','" + a + "','" + textBox3.Text + " ','" + textBox4.Text + " ','" + comboBox1.SelectedItem.ToString() + " ')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Stored");
        }
    }
}
