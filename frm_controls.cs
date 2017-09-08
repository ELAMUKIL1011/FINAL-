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
    public partial class frm_controls : Form
    {
        public frm_controls()
        {
            InitializeComponent();

            lst_cities.Items.Add("chennai");
                lst_cities.Items.Add("pune");
            lst_cities.Items.Add("mumbai");
            lst_cities.Items.Add("delhi");
            cmb_departments.Items.Add("it");
            cmb_departments.Items.Add("hr");
            cmb_departments.Items.Add("accounts");
            btn_validate.Enabled = false;
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (lst_cities.Text == "")
            {

                MessageBox.Show("select a city");

            }
            else if(cmb_departments.Text == "")
            {
                MessageBox.Show("select a  dep");
               
            }
            else if (chk_status.Checked == false)
            {
                MessageBox.Show(" check the status box");
            }


            else if (rdb_female.Checked == false && rdb_male.Checked == false)
            {
                MessageBox.Show("enter a gender");
            }

            else
            {

                MessageBox.Show("you have selected : " + lst_cities.Text);
                MessageBox.Show("you have selected" + cmb_departments.Text);
                string gender="";
                if(rdb_male.Checked)
                {
                gender= "male";
                }
                else{
                gender="female";
                }



                MessageBox.Show("you have selected" +gender);
            }

        }

        private void cmb_departments_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            

        }

        private void chk_status_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_status.Checked)
            {
                btn_validate.Enabled = true;

            }
            else
            {
                btn_validate.Enabled = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
