﻿namespace Win_threads
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_mainthread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mainthread
            // 
            this.btn_mainthread.Location = new System.Drawing.Point(57, 124);
            this.btn_mainthread.Name = "btn_mainthread";
            this.btn_mainthread.Size = new System.Drawing.Size(190, 98);
            this.btn_mainthread.TabIndex = 0;
            this.btn_mainthread.Text = "MAIN THREAD";
            this.btn_mainthread.UseVisualStyleBackColor = true;
            this.btn_mainthread.Click += new System.EventHandler(this.btn_mainthread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_mainthread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mainthread;
    }
}

