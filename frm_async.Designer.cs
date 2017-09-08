namespace Win_threads
{
    partial class frm_async
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
            this.lbl_perdaysalary = new System.Windows.Forms.Label();
            this.lbl_numberofdays = new System.Windows.Forms.Label();
            this.txt_perdaysalary = new System.Windows.Forms.TextBox();
            this.txt_numberofdays = new System.Windows.Forms.TextBox();
            this.btn_salary = new System.Windows.Forms.Button();
            this.lbl_employeeid = new System.Windows.Forms.Label();
            this.txt_employeeid = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_perdaysalary
            // 
            this.lbl_perdaysalary.AutoSize = true;
            this.lbl_perdaysalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perdaysalary.Location = new System.Drawing.Point(62, 115);
            this.lbl_perdaysalary.Name = "lbl_perdaysalary";
            this.lbl_perdaysalary.Size = new System.Drawing.Size(162, 25);
            this.lbl_perdaysalary.TabIndex = 0;
            this.lbl_perdaysalary.Text = "per day salary";
            // 
            // lbl_numberofdays
            // 
            this.lbl_numberofdays.AutoSize = true;
            this.lbl_numberofdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberofdays.Location = new System.Drawing.Point(50, 155);
            this.lbl_numberofdays.Name = "lbl_numberofdays";
            this.lbl_numberofdays.Size = new System.Drawing.Size(174, 25);
            this.lbl_numberofdays.TabIndex = 1;
            this.lbl_numberofdays.Text = "number of days";
            // 
            // txt_perdaysalary
            // 
            this.txt_perdaysalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_perdaysalary.Location = new System.Drawing.Point(304, 112);
            this.txt_perdaysalary.Name = "txt_perdaysalary";
            this.txt_perdaysalary.Size = new System.Drawing.Size(100, 31);
            this.txt_perdaysalary.TabIndex = 2;
            // 
            // txt_numberofdays
            // 
            this.txt_numberofdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberofdays.Location = new System.Drawing.Point(304, 155);
            this.txt_numberofdays.Name = "txt_numberofdays";
            this.txt_numberofdays.Size = new System.Drawing.Size(100, 31);
            this.txt_numberofdays.TabIndex = 3;
            // 
            // btn_salary
            // 
            this.btn_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salary.Location = new System.Drawing.Point(233, 242);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(115, 47);
            this.btn_salary.TabIndex = 4;
            this.btn_salary.Text = "salary";
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // lbl_employeeid
            // 
            this.lbl_employeeid.AutoSize = true;
            this.lbl_employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employeeid.Location = new System.Drawing.Point(88, 72);
            this.lbl_employeeid.Name = "lbl_employeeid";
            this.lbl_employeeid.Size = new System.Drawing.Size(119, 25);
            this.lbl_employeeid.TabIndex = 0;
            this.lbl_employeeid.Text = "empolyeid";
            // 
            // txt_employeeid
            // 
            this.txt_employeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employeeid.Location = new System.Drawing.Point(304, 72);
            this.txt_employeeid.Name = "txt_employeeid";
            this.txt_employeeid.Size = new System.Drawing.Size(100, 31);
            this.txt_employeeid.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(108, 315);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 25);
            this.lbl_result.TabIndex = 1;
            // 
            // frm_async
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 526);
            this.Controls.Add(this.btn_salary);
            this.Controls.Add(this.txt_numberofdays);
            this.Controls.Add(this.txt_employeeid);
            this.Controls.Add(this.lbl_employeeid);
            this.Controls.Add(this.txt_perdaysalary);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_numberofdays);
            this.Controls.Add(this.lbl_perdaysalary);
            this.Name = "frm_async";
            this.Text = "frm_async";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_perdaysalary;
        private System.Windows.Forms.Label lbl_numberofdays;
        private System.Windows.Forms.TextBox txt_perdaysalary;
        private System.Windows.Forms.TextBox txt_numberofdays;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Label lbl_employeeid;
        private System.Windows.Forms.TextBox txt_employeeid;
        private System.Windows.Forms.Label lbl_result;
    }
}