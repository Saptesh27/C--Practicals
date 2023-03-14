using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace timer1.cs
{
    public partial class Form1 : Form
    {
        int second = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            second = second + 1;
            progressBar1.Visible = true;
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value == 15)
            {
                form2 f2 = new form2();
                f2.Show();
                progressBar1.Visible = false;
            }

            if (second >= 15)
            {
                timer1.Stop();
                MessageBox.Show("Existing from timer....");
            }

        }
    }
}
