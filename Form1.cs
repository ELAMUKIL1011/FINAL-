using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading; // must for thread

namespace Win_threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mainthread_Click(object sender, EventArgs e)
        {
            int threadid = Thread.CurrentThread.ManagedThreadId; // reference of thread
            MessageBox.Show("main thread"+ threadid);
            ThreadStart ths = new ThreadStart(task); // threastart is delegate 
            Thread th = new Thread(ths);// wrapper class 
            th.IsBackground = true; // to close all window once main is closed
            th.Start();

            MessageBox.Show("some other task" + i);


        }
        int i = 0;

        public void task()
        {
            i = 5000;
            int threadid = Thread.CurrentThread.ManagedThreadId;
            MessageBox.Show("new task" + threadid);


        
        }
    }
}
