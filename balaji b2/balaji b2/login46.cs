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
    public partial class login46 : Form
    {
        public login46()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "nilima" && textBox2.Text == "nilima24")
            {
                Dashboard b1 = new Dashboard();
                b1.Show();
            }
            else
            {
                MessageBox.Show("incorrect user or pass");
            }
        
        }

        private void login46_Load(object sender, EventArgs e)
        {

        }
    }
}
