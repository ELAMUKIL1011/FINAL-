using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Win_ado_day1
{
    public partial class frm_login : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        public frm_login()
        {
            InitializeComponent();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com_login = new SqlCommand(@"select count (*) from customer
where customerid = @customerid and customerpassword= @customerpassword", con);
            com_login.Parameters.AddWithValue("@customerid" , txt_loginid.Text);
            com_login.Parameters.AddWithValue("@customerpassword", txt_password.Text);
            int count = Convert.ToInt32(com_login.ExecuteScalar());
            


            con.Close();
            if (count > 0)
            { 
            
            MessageBox.Show("Valid user");
            }
            else
            {
                MessageBox.Show("invalid user");
            
            }
        }
    }
}
