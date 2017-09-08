using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace assignment_windows_day5
{
    public partial class Form1 : Form
    {

        private List<order> list_orders = new List<order>();
        string payment;
        int ordervalue;
        
        public Form1()
        {
            InitializeComponent();
          
            cmb_city.Items.Add("CHENNAI");
            cmb_city.Items.Add("TRICHY");
            cmb_city.Items.Add("MADURAI");
            cmb_city.Items.Add("COIMBATORE");
           

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txt_customername.Text == "")
            {

                MessageBox.Show("enter your name");
            }
            else  if (txt_itemname.Text == "")
            {
                MessageBox.Show("enter item name");
            
            }
               
            else if (txt_itemprice.Text =="")
            {
                MessageBox.Show("enter the item price");
            }
            else if (txt_itemquantity.Text == "")
            {
                MessageBox.Show("enter item quantity");
            
            }
            else if (txt_deliveryaddress.Text == "")
            {
                MessageBox.Show("enter delivery address");
            }

            else if (rdb_COD.Checked == false && rdb_NET.Checked== false && rdb_PAYTM.Checked ==false)
            {
            MessageBox.Show("select the payment mode");
            }
            else
            {
                int quantity= Convert.ToInt32(txt_itemquantity.Text);
                int price= Convert.ToInt32(txt_itemprice.Text);
                string name = txt_customername.Text;
                string address = txt_deliveryaddress.Text;
                string city = cmb_city.Text;
              
                string itemname =txt_itemname.Text;

              btn_placeorder.Enabled = true;
          
                if(rdb_COD.Checked)
                {
               payment = "COD";
                }
                else if(rdb_NET.Checked)
                {
                payment =" NET BANKING";
                }
                else if (rdb_PAYTM.Checked)
                {
                
                payment="PAYTM";
                }
                string paymentoption = payment;
                order ord = new order(quantity, price,name,city,address,paymentoption,itemname);
                
                list_orders.Add(ord);
                MessageBox.Show(" YOUR ORDER ID :" + ord.porderid + " TOTAL VALUE " + ord.getordervalue()); 
            
                
            
                
            
            
            
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_showorders_Click(object sender, EventArgs e)
        {
            dg_orders.DataSource = null;
            dg_orders.DataSource = list_orders;
        }

        private void dg_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_customername.Text = "";
            txt_deliveryaddress.Text = "";
            txt_itemname.Text = "";
            txt_itemprice.Text = "";
            txt_itemquantity.Text = "";
            rdb_COD.Checked = false;
            rdb_NET.Checked = false;
            rdb_PAYTM.Checked = false;
            cmb_city.Text = "select a city";

        }
    }
}
