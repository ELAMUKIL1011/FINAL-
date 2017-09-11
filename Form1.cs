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
namespace win_ado_day1_assignment
{
    public partial class Form1 : Form
    {
        SqlConnection con = new 
            SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
            cmb_itemquantity.Items.Add("1");
            cmb_itemquantity.Items.Add("2");
            cmb_itemquantity.Items.Add("3");
            cmb_itemquantity.Items.Add("4");
            cmb_itemquantity.Items.Add("5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand find_user = new SqlCommand
                (@"select count(*) from customer where customerid=@customerid", con);
            int customerid = Convert.ToInt32(txt_customerid.Text);
            find_user.Parameters.AddWithValue("@customerid", customerid);
            int count = Convert.ToInt32(find_user.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand update_order = new SqlCommand(@"insert orders values 
(@customerid,@itemid,@itemqty,getdate()) ", con);
                update_order.Parameters.AddWithValue("@customerid", txt_customerid.Text);
                update_order.Parameters.AddWithValue("@itemid", cmb_itemname.SelectedValue);
                update_order.Parameters.AddWithValue("@itemqty", cmb_itemquantity.Text);
                
                update_order.ExecuteNonQuery();


                SqlCommand get_orderid = new SqlCommand("select @@identity", con);
                int orderid= Convert.ToInt32(get_orderid.ExecuteScalar());
                txt_orderid.Text = orderid.ToString();

            
                MessageBox.Show("order placed + order id " + orderid);
              

              
            }
            else
            {
                MessageBox.Show("invalid customer id");
            
            }



            con.Close();
     

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            List<item> list_item = new List<item>();

            SqlCommand read_items = new SqlCommand(@"select * from items",con);
            SqlDataReader dr_readitems = read_items.ExecuteReader();
 
            while (dr_readitems.Read())
            {
                item i = new item();
                i.itemid = dr_readitems.GetInt32(0);
                i.itemname = dr_readitems.GetString(1);
                list_item.Add(i);
            
            
            }
con.Close();
              cmb_itemname.DisplayMember = "itemname";
            cmb_itemname.ValueMember = "itemid";


            cmb_itemname.DataSource = list_item;



         
            

        }

   

        private void cmb_itemquantity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_itemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();           
            SqlCommand show_price = new SqlCommand
                (@"select itemprice from items where itemid=@itemid", con);
            
            show_price.Parameters.AddWithValue("@itemid",cmb_itemname.SelectedValue);
            SqlDataReader read_itemname = show_price.ExecuteReader();
            if (read_itemname.Read())
            {

                txt_itemprice.Text = read_itemname.GetInt32(0).ToString();
                

            }
            con.Close();
        }
    }
}
