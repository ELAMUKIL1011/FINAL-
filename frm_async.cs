using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win_threads
{
    public partial class frm_async : Form
    {
        public delegate int del_getsalary(int perdaysalary, int days);
        del_getsalary obj;

        public frm_async()
        {
            InitializeComponent();
            obj = new del_getsalary(getsalary);
        }

        
        
        private void btn_salary_Click(object sender, EventArgs e)
        {
int perdaysalary=Convert.ToInt32(txt_perdaysalary.Text);
          
  int days= Convert.ToInt32(txt_numberofdays.Text);
            
string empid=txt_employeeid.Text;
            // int total= obj(100, 10); //sync 
obj.BeginInvoke(perdaysalary, days, new AsyncCallback(callback), empid);



        }


        public delegate void del();
        public void callback(IAsyncResult res)
        {

         
                int salary =obj.EndInvoke(res);
                

            
               // MessageBox.Show("salary of employe id:   " + res.AsyncState + " salary :" + salary);

                del objdel = delegate
                {
                    lbl_result.Text = "employee id :" + res.AsyncState + "salary " + salary;


                };
                this.BeginInvoke(objdel);// main thread will run this func


        }


       


        public int getsalary(int perdaysalary, int numberofdays)
        {

            int total = perdaysalary * numberofdays;
            return total;
        
        }



    }
}
