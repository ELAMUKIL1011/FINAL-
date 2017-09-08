using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Win_threads_assignment
{
    public partial class Form1 : Form
    {
        public delegate int del_result(int num1,int num2,string operation);
        del_result obj;
        
        public Form1()
        {
            InitializeComponent();
            obj = new del_result(getresult);
        }

      

       
        private void btn_add_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_num1.Text);
            int n2 = Convert.ToInt32(txt_num2.Text);
            string operation = "add";
            string S = n1 + " + " + n2;
            obj.BeginInvoke(n1, n2, operation, new AsyncCallback(callback),S);
        }
        private void btn_divide_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_num1.Text);
            int n2 = Convert.ToInt32(txt_num2.Text);
            string operation = "divide";
            string S = n1 + " / " + n2;
            obj.BeginInvoke(n1, n2, operation, new AsyncCallback(callback),S);
        }
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_num1.Text);
            int n2 = Convert.ToInt32(txt_num2.Text);
            string S = n1 + " X " + n2;
            string operation = "multiply";
            obj.BeginInvoke(n1, n2, operation, new AsyncCallback(callback), S);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_num1.Text);
            int n2 = Convert.ToInt32(txt_num2.Text);
            string operation = "sub";
            string S = n1 + " - " + n2;
            obj.BeginInvoke(n1, n2, operation, new AsyncCallback(callback),S);
        }

        public delegate void del();
        public void callback(IAsyncResult res)
        {
           

            int result = obj.EndInvoke(res);

            
            del objdel = delegate
            {
              list_result.Items.Add("RESULT OF "+ res.AsyncState +" : " + result);
             

            };
            this.BeginInvoke(objdel);


        }

        int result;
        public int getresult(int num1, int num2, string operation)
        { 
            switch (operation)
            { 
                case "add":
                    result = num1 + num2;
                    break;
                case "sub":
                    result = num1 - num2;
                    break;
                case "multiply":
                    result = num1 * num2;
                    break;
                case "divide":
                    result = num1 / num2;
                    break;

            
            }
            return result;
        
        }

      
       
        
    }
}
