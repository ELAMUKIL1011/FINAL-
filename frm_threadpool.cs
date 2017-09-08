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
    public partial class frm_threadpool : Form
    {
        public frm_threadpool()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadPool.SetMinThreads(5, 1000);
            ThreadPool.SetMaxThreads(10, 1000);
            int count = 0;
            while (count < 20)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(call), count);
                count++;
            
            }
           MessageBox.Show("mainthread  ");
        }

        public void call(object obj)
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            MessageBox.Show("thread id : " + id + " ,loop: " + obj);
        
        }
    }
}
