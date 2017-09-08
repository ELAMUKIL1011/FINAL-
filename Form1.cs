using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sum_library;
namespace Win_assembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text);
            int num2 = Convert.ToInt32(txt_num2.Text);
             // refering to library
            //reads the lib
            sum_library.clac sumobj = new sum_library.clac(); // or use the using namespace func 
           // clac 0=new clac();


            int sum =sumobj.getsum(num1, num2); // reflection 
            MessageBox.Show("total" + sum);
        }
    }
}
