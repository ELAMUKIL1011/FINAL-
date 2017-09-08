using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            DateTime t = DateTime.Today;
            textBox2.Text = Convert.ToString((Convert.ToInt32(t-(Convert.ToDateTime(textBox1.Text))))/365);



        }
    }
}
