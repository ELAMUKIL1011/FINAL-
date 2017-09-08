using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace assignment_assembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            int perdaysal = Convert.ToInt32(txt_perdaysal.Text);
            int numberofdays = Convert.ToInt32(txt_numofdays.Text);
            calc_sal.Class1 obj = new calc_sal.Class1();

            


            int sal = obj.getsalary(perdaysal,numberofdays); 
            MessageBox.Show("salary  : " + sal);
        }
    }
}
