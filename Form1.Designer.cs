namespace win_day1
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
            this.btn_addcustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addcustomer
            // 
            this.btn_addcustomer.Location = new System.Drawing.Point(308, 174);
            this.btn_addcustomer.Name = "btn_addcustomer";
            this.btn_addcustomer.Size = new System.Drawing.Size(371, 144);
            this.btn_addcustomer.TabIndex = 0;
            this.btn_addcustomer.Text = "btn_addcustomer\r\n\r\n";
            this.btn_addcustomer.UseVisualStyleBackColor = true;
            this.btn_addcustomer.Click += new System.EventHandler(this.btn_addcustomer_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "btn_addcustomer ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 564);
            this.Controls.Add(this.btn_addcustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addcustomer;
    }
}

