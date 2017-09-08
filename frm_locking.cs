using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Win_threads
{
    public partial class frm_locking : Form
    {
        object obj = new object();
        public frm_locking()
        {
            InitializeComponent();
        }
        int total;
        public void calc()
        {
            
          //lock (obj)
          //{
            bool flag = true;
            while (flag)
            {



                if (Monitor.TryEnter(this))
                {
                    int n1 = Convert.ToInt32(txt_num1.Text);
                    int n2 = Convert.ToInt32(txt_num2.Text);
                    total = n1 + n2;
                    Thread.Sleep(10000);
                    Monitor.Exit(this);
                    flag = false;
                    MessageBox.Show("total" + total);
                    
                }
                else
                {


                    MessageBox.Show("object locked ");
                }
            }

         // }

        
        }

        private void btn_thread1_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(calc);
            th1.Start();
        }

        private void btn_thread2_Click(object sender, EventArgs e)
        {
            Thread th2 = new Thread(calc);
            th2.Start();
        }
    }
}
