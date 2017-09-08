namespace assignment_assembly
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
            this.lbl_perdaysal = new System.Windows.Forms.Label();
            this.txt_perdaysal = new System.Windows.Forms.TextBox();
            this.lbl_nodays = new System.Windows.Forms.Label();
            this.txt_numofdays = new System.Windows.Forms.TextBox();
            this.btn_salary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_perdaysal
            // 
            this.lbl_perdaysal.AutoSize = true;
            this.lbl_perdaysal.Location = new System.Drawing.Point(77, 30);
            this.lbl_perdaysal.Name = "lbl_perdaysal";
            this.lbl_perdaysal.Size = new System.Drawing.Size(72, 13);
            this.lbl_perdaysal.TabIndex = 0;
            this.lbl_perdaysal.Text = "per day salary";
            // 
            // txt_perdaysal
            // 
            this.txt_perdaysal.Location = new System.Drawing.Point(208, 30);
            this.txt_perdaysal.Name = "txt_perdaysal";
            this.txt_perdaysal.Size = new System.Drawing.Size(100, 20);
            this.txt_perdaysal.TabIndex = 1;
            // 
            // lbl_nodays
            // 
            this.lbl_nodays.AutoSize = true;
            this.lbl_nodays.Location = new System.Drawing.Point(70, 63);
            this.lbl_nodays.Name = "lbl_nodays";
            this.lbl_nodays.Size = new System.Drawing.Size(79, 13);
            this.lbl_nodays.TabIndex = 2;
            this.lbl_nodays.Text = "number of days";
            // 
            // txt_numofdays
            // 
            this.txt_numofdays.Location = new System.Drawing.Point(208, 63);
            this.txt_numofdays.Name = "txt_numofdays";
            this.txt_numofdays.Size = new System.Drawing.Size(100, 20);
            this.txt_numofdays.TabIndex = 3;
            // 
            // btn_salary
            // 
            this.btn_salary.Location = new System.Drawing.Point(133, 122);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(75, 23);
            this.btn_salary.TabIndex = 4;
            this.btn_salary.Text = "salary";
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 352);
            this.Controls.Add(this.btn_salary);
            this.Controls.Add(this.txt_numofdays);
            this.Controls.Add(this.lbl_nodays);
            this.Controls.Add(this.txt_perdaysal);
            this.Controls.Add(this.lbl_perdaysal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_perdaysal;
        private System.Windows.Forms.TextBox txt_perdaysal;
        private System.Windows.Forms.Label lbl_nodays;
        private System.Windows.Forms.TextBox txt_numofdays;
        private System.Windows.Forms.Button btn_salary;
    }
}

