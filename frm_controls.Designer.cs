namespace Win_day5
{
    partial class frm_controls
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
            this.lst_cities = new System.Windows.Forms.ListBox();
            this.btn_validate = new System.Windows.Forms.Button();
            this.cmb_departments = new System.Windows.Forms.ComboBox();
            this.chk_status = new System.Windows.Forms.CheckBox();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lst_cities
            // 
            this.lst_cities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_cities.FormattingEnabled = true;
            this.lst_cities.ItemHeight = 25;
            this.lst_cities.Location = new System.Drawing.Point(12, 151);
            this.lst_cities.Name = "lst_cities";
            this.lst_cities.Size = new System.Drawing.Size(120, 179);
            this.lst_cities.TabIndex = 0;
            // 
            // btn_validate
            // 
            this.btn_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validate.Location = new System.Drawing.Point(279, 186);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(254, 58);
            this.btn_validate.TabIndex = 1;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // cmb_departments
            // 
            this.cmb_departments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_departments.FormattingEnabled = true;
            this.cmb_departments.Location = new System.Drawing.Point(12, 25);
            this.cmb_departments.Name = "cmb_departments";
            this.cmb_departments.Size = new System.Drawing.Size(215, 33);
            this.cmb_departments.TabIndex = 2;
            this.cmb_departments.SelectedIndexChanged += new System.EventHandler(this.cmb_departments_SelectedIndexChanged);
            // 
            // chk_status
            // 
            this.chk_status.AutoSize = true;
            this.chk_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_status.Location = new System.Drawing.Point(12, 90);
            this.chk_status.Name = "chk_status";
            this.chk_status.Size = new System.Drawing.Size(89, 29);
            this.chk_status.TabIndex = 3;
            this.chk_status.Text = "status";
            this.chk_status.UseVisualStyleBackColor = true;
            this.chk_status.CheckedChanged += new System.EventHandler(this.chk_status_CheckedChanged);
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_male.Location = new System.Drawing.Point(22, 350);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(68, 29);
            this.rdb_male.TabIndex = 4;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "male";
            this.rdb_male.UseVisualStyleBackColor = true;
            this.rdb_male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_female.Location = new System.Drawing.Point(116, 350);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(83, 29);
            this.rdb_female.TabIndex = 5;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "female";
            this.rdb_female.UseVisualStyleBackColor = true;
            // 
            // frm_controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 443);
            this.Controls.Add(this.rdb_female);
            this.Controls.Add(this.rdb_male);
            this.Controls.Add(this.chk_status);
            this.Controls.Add(this.cmb_departments);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.lst_cities);
            this.Name = "frm_controls";
            this.Text = "frm_controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_cities;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.ComboBox cmb_departments;
        private System.Windows.Forms.CheckBox chk_status;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.RadioButton rdb_female;
    }
}