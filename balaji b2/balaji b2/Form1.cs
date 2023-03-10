using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace balaji_b2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            if (radioButton1.Checked == true)
            {
                a = radioButton1.Text;
            }
            else
            {
                a = radioButton2.Text;
            }
            label8.Text = textBox1.Text;
            label9.Text = textBox2.Text;
            label10.Text = a;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
            label13.Text = comboBox1.SelectedItem.ToString();

        }
    }
}
