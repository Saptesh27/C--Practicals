using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace imrdstud
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\MyDB.accdb");
        OleDbCommand cmd = new OleDbCommand();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lable4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Insert into stud values('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ")";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Stored Succesfully...");
        }
    }
}
