using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace win_ado_day1_assignment
{
    public partial class frm_findorder : Form
    {
        SqlConnection con = new
               SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        public frm_findorder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_findorder_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand find_order =
new SqlCommand(@"select orders.customerid,items.itemname,orders.itemqty,orders.orderdate,items.itemprice
from orders
join items 
on orders.itemid= items.itemid
where orders.orderid=@orderid", con);
            int orderid = Convert.ToInt32(txt_orderid.Text);
            find_order.Parameters.AddWithValue("@orderid", orderid);
            SqlDataReader read_orders = find_order.ExecuteReader();
            if (read_orders.Read())
            {

                 lbl_customeridres.Text = read_orders.GetInt32(0).ToString();
                lbl_itemnameres.Text = read_orders.GetString(1);
                lbl_itemqtyres.Text = read_orders.GetInt32(2).ToString();

               lbl_orderdateres.Text = read_orders.GetDateTime(3).ToString();
               lbl_itempriceres.Text = read_orders.GetInt32(4).ToString();

            }
            else
            {
                MessageBox.Show("orderid not found");

            }
            con.Close();
        }
    }
}
