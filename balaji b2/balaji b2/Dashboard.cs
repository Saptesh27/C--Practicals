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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p1 = new Product();
            p1.Show();

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
