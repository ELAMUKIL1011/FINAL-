namespace Win_threads
{
    partial class frm_threadpool
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
            this.btn_threadpool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_threadpool
            // 
            this.btn_threadpool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_threadpool.Location = new System.Drawing.Point(229, 316);
            this.btn_threadpool.Name = "btn_threadpool";
            this.btn_threadpool.Size = new System.Drawing.Size(154, 67);
            this.btn_threadpool.TabIndex = 0;
            this.btn_threadpool.Text = "threadpool";
            this.btn_threadpool.UseVisualStyleBackColor = true;
            this.btn_threadpool.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_threadpool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 458);
            this.Controls.Add(this.btn_threadpool);
            this.Name = "frm_threadpool";
            this.Text = "frm_threadpool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_threadpool;
    }
}