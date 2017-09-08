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
    public partial class frm_threadlifecycle : Form
    {
        Bitmap b1 = new Bitmap(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg");
        Bitmap b2 = new Bitmap(@"C:\Users\Public\Pictures\Sample Pictures\Hydrangeas.jpg");
        Bitmap b3 = new Bitmap(@"C:\Users\Public\Pictures\Sample Pictures\Penguins.jpg");
        Bitmap b4 = new Bitmap(@"C:\Users\Public\Pictures\Sample Pictures\Jellyfish.jpg");
        Bitmap b5 = new Bitmap(@"C:\Users\Public\Pictures\Sample Pictures\Tulips.jpg");
        public void loadimages()
        {

            while (true)

            {
                picbox_pic.Image = b1;
                Thread.Sleep(2000);
                 picbox_pic.Image = b2;
                Thread.Sleep(2000);
                picbox_pic.Image = b3;
                Thread.Sleep(2000);
                picbox_pic.Image = b4;
                Thread.Sleep(2000);
                picbox_pic.Image = b5;
                Thread.Sleep(2000);
            
            
            
            }
        }
        public frm_threadlifecycle()
        {
            InitializeComponent();
        }
        Thread th;
        private void btn_mainthread_Click(object sender, EventArgs e)
        {
            MessageBox.Show("main thread task");
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            th.Suspend();
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            th.Resume();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            th.Abort();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            th = new Thread(loadimages);
            th.IsBackground = true; // closing main thread will close all the thread
            th.Start();
        }
    }
}
