namespace Win_threads
{
    partial class frm_threadlifecycle
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_mainthread = new System.Windows.Forms.Button();
            this.picbox_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(25, 97);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(125, 92);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.Location = new System.Drawing.Point(12, 213);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(190, 73);
            this.btn_pause.TabIndex = 1;
            this.btn_pause.Text = "pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_resume
            // 
            this.btn_resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resume.Location = new System.Drawing.Point(12, 324);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(155, 53);
            this.btn_resume.TabIndex = 2;
            this.btn_resume.Text = "resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(25, 399);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(94, 77);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_mainthread
            // 
            this.btn_mainthread.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainthread.Location = new System.Drawing.Point(334, 345);
            this.btn_mainthread.Name = "btn_mainthread";
            this.btn_mainthread.Size = new System.Drawing.Size(133, 118);
            this.btn_mainthread.TabIndex = 4;
            this.btn_mainthread.Text = "main thread";
            this.btn_mainthread.UseVisualStyleBackColor = true;
            this.btn_mainthread.Click += new System.EventHandler(this.btn_mainthread_Click);
            // 
            // picbox_pic
            // 
            this.picbox_pic.Location = new System.Drawing.Point(247, 81);
            this.picbox_pic.Name = "picbox_pic";
            this.picbox_pic.Size = new System.Drawing.Size(293, 189);
            this.picbox_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_pic.TabIndex = 5;
            this.picbox_pic.TabStop = false;
            // 
            // frm_threadlifecycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 475);
            this.Controls.Add(this.picbox_pic);
            this.Controls.Add(this.btn_mainthread);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_start);
            this.Name = "frm_threadlifecycle";
            this.Text = "frm_threadlifecycle";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_mainthread;
        private System.Windows.Forms.PictureBox picbox_pic;
    }
}