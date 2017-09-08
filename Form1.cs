using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win_day5
{
    public partial class Frm_login /*  class */ : Form
    {
        public Frm_login() // constructor 
        {
            InitializeComponent();
        }

       

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_loginid.Text == "")
            {
                MessageBox.Show("enter login id");
            }
            else if (txt_pass.Text == "")
            {

                MessageBox.Show("enter password");
            }
            else
            {

                int loginid = Convert.ToInt32(txt_loginid.Text);
                string password = txt_pass.Text;
                if (loginid == 1001 && password == "password123")
                {
                    MessageBox.Show("valid user");
                    frm_controls obj = new frm_controls();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("invalid user");
                }
            }

        }
    }
}
