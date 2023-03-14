using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Student_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
            toolTip.SetToolTip(button1,"Save Data");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Violet;
            toolTip.SetToolTip(button4, "Update Data");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            toolTip.SetToolTip(button3, "Delete Record");
        }


        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightSkyBlue;
            toolTip.SetToolTip(button2, "Show Records");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Student.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into Stud(sroll, sname, sadd) values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Stored");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Student.accdb");
            OleDbCommand cmd = new OleDbCommand("update Stud set sname='" + textBox2.Text + "',sadd='" + textBox3.Text + "' where sroll="+textBox1.Text+"", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Student.accdb");
            OleDbCommand cmd = new OleDbCommand("delete from Stud where sroll="+textBox1.Text+"", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Record Deleted");
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Student.accdb");
            OleDbDataAdapter da = new OleDbDataAdapter("select  * from Stud", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds,"Stud");
            dataGridView1.DataSource = ds.Tables["Stud"].DefaultView;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ControlLight;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.ControlLight;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.ControlLight;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.ControlLight;
        }

    }
}
