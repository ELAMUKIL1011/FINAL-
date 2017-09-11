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
    public partial class Form1 : Form
    {
        SqlConnection con =
                 new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_customerage.Text = "";
            cmb_cities.Text = "";
            txt_customerid.Text = "";
            txt_customername.Text = "";
            txt_customerpassword.Text = "";

        }

        private void btn_addcustomer_Click(object sender, EventArgs e)
        {
           
            con.Open();

            SqlCommand com_customers_insert = 
                new SqlCommand("insert customer values (@customername,@customerage,@customercityid,@customerpassword)", con);


            com_customers_insert.Parameters.AddWithValue("@customername", txt_customername.Text);
            com_customers_insert.Parameters.AddWithValue("@customerage", txt_customerage.Text);
            com_customers_insert.Parameters.AddWithValue("@customercityid", cmb_cities.SelectedValue);// cityid;
            com_customers_insert.Parameters.AddWithValue("@customerpassword", txt_customerpassword.Text);

            com_customers_insert.ExecuteNonQuery();
            SqlCommand com_customerid= new SqlCommand ("Select @@identity",con);
            int customerid= Convert.ToInt32(com_customerid.ExecuteScalar());
            txt_customerid.Text= customerid.ToString();


            con.Close();
            MessageBox.Show("cusotmer added , customer id" + customerid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();

            List<city> list_cities = new List<city>();
            SqlCommand com_read_cities = new SqlCommand("select * from cities", con);
            SqlDataReader dr_cities = com_read_cities.ExecuteReader();
            while (dr_cities.Read())
            {


                city c = new city();
                c.cityid = dr_cities.GetInt32(0);
                c.cityname = dr_cities.GetString(1);
                list_cities.Add(c);
            
            }



            con.Close();
            cmb_cities.DataSource = list_cities;
            cmb_cities.DisplayMember = "cityname";
            cmb_cities.ValueMember = "cityid";
        }

        private void btn_findcustomer_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand com_read_customer = new SqlCommand
            (@"select customerid,customername,customerage,cityname
from customer
join cities on
customer.customercityid=cities.cityid where customerid=@customerid", con);
            int customerid = Convert.ToInt32(txt_customerid.Text);
            com_read_customer.Parameters.AddWithValue("@customerid", customerid);
            SqlDataReader dr_customer = com_read_customer.ExecuteReader();
            if (dr_customer.Read())
            {

                txt_customerid.Text = dr_customer.GetInt32(0).ToString();
                txt_customername.Text = dr_customer.GetString(1);
                txt_customerage.Text = dr_customer.GetInt32(2).ToString();
                cmb_cities.Text = dr_customer.GetString(3);
            
            }
            else
            {

                MessageBox.Show("customer not found");
            
            }




            con.Close();

        }

        private void btn_updatecustomer_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand com_update_customer = new SqlCommand(@"update customer set 
customername = @customername,customercityid =@customercityid 
where customerid=@customerid", con);
            com_update_customer.Parameters.AddWithValue("@customername", txt_customername.Text);
            com_update_customer.Parameters.AddWithValue("@customercityid", cmb_cities.SelectedValue);
            com_update_customer.Parameters.AddWithValue("@customerid", txt_customerid.Text);
            int count = com_update_customer.ExecuteNonQuery();



            con.Close();
            if (count > 0)
            {
                MessageBox.Show("customer updated");

            }
            else {

                MessageBox.Show("customer not found");
            }

        }

        private void btn_deletecustomer_Click(object sender, EventArgs e)
        {
         DialogResult result=   MessageBox.Show("do you want to delete this customer ?"," delete ?" ,MessageBoxButtons.YesNo);
         if (result == DialogResult.Yes)
         {

             con.Open();
             SqlCommand com_delete_customer = new SqlCommand(@"delete customer where customerid=@customerid", con);
             com_delete_customer.Parameters.AddWithValue("@customerid", txt_customerid.Text);
             int count = com_delete_customer.ExecuteNonQuery();
             con.Close();
             if (count > 0)
             {

                 MessageBox.Show("customer deleted");



             }
             else
             {
                 MessageBox.Show("customer not found");
             
             }

         
         }
         





        }

    }
}
