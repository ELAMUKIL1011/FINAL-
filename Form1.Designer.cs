namespace Win_ado_day1
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
            this.lbl_customerid = new System.Windows.Forms.Label();
            this.lbl_customername = new System.Windows.Forms.Label();
            this.lbl_customerage = new System.Windows.Forms.Label();
            this.lbl_customercity = new System.Windows.Forms.Label();
            this.lbl_customerpassword = new System.Windows.Forms.Label();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.txt_customerage = new System.Windows.Forms.TextBox();
            this.txt_customerpassword = new System.Windows.Forms.TextBox();
            this.btn_addcustomer = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmb_cities = new System.Windows.Forms.ComboBox();
            this.btn_findcustomer = new System.Windows.Forms.Button();
            this.btn_updatecustomer = new System.Windows.Forms.Button();
            this.btn_deletecustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_customerid
            // 
            this.lbl_customerid.AutoSize = true;
            this.lbl_customerid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerid.Location = new System.Drawing.Point(89, 42);
            this.lbl_customerid.Name = "lbl_customerid";
            this.lbl_customerid.Size = new System.Drawing.Size(126, 33);
            this.lbl_customerid.TabIndex = 0;
            this.lbl_customerid.Text = "customer id";
            this.lbl_customerid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_customername
            // 
            this.lbl_customername.AutoSize = true;
            this.lbl_customername.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customername.Location = new System.Drawing.Point(77, 89);
            this.lbl_customername.Name = "lbl_customername";
            this.lbl_customername.Size = new System.Drawing.Size(155, 33);
            this.lbl_customername.TabIndex = 1;
            this.lbl_customername.Text = "customer name";
            // 
            // lbl_customerage
            // 
            this.lbl_customerage.AutoSize = true;
            this.lbl_customerage.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerage.Location = new System.Drawing.Point(77, 136);
            this.lbl_customerage.Name = "lbl_customerage";
            this.lbl_customerage.Size = new System.Drawing.Size(142, 33);
            this.lbl_customerage.TabIndex = 2;
            this.lbl_customerage.Text = "customer age";
            // 
            // lbl_customercity
            // 
            this.lbl_customercity.AutoSize = true;
            this.lbl_customercity.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customercity.Location = new System.Drawing.Point(71, 183);
            this.lbl_customercity.Name = "lbl_customercity";
            this.lbl_customercity.Size = new System.Drawing.Size(144, 33);
            this.lbl_customercity.TabIndex = 3;
            this.lbl_customercity.Text = "customer city";
            this.lbl_customercity.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_customerpassword
            // 
            this.lbl_customerpassword.AutoSize = true;
            this.lbl_customerpassword.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerpassword.Location = new System.Drawing.Point(54, 238);
            this.lbl_customerpassword.Name = "lbl_customerpassword";
            this.lbl_customerpassword.Size = new System.Drawing.Size(200, 33);
            this.lbl_customerpassword.TabIndex = 4;
            this.lbl_customerpassword.Text = "customer password";
            // 
            // txt_customerid
            // 
            this.txt_customerid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerid.Location = new System.Drawing.Point(295, 42);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(100, 41);
            this.txt_customerid.TabIndex = 5;
            // 
            // txt_customername
            // 
            this.txt_customername.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.Location = new System.Drawing.Point(295, 89);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(213, 41);
            this.txt_customername.TabIndex = 6;
            // 
            // txt_customerage
            // 
            this.txt_customerage.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerage.Location = new System.Drawing.Point(295, 136);
            this.txt_customerage.Name = "txt_customerage";
            this.txt_customerage.Size = new System.Drawing.Size(59, 41);
            this.txt_customerage.TabIndex = 7;
            // 
            // txt_customerpassword
            // 
            this.txt_customerpassword.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerpassword.Location = new System.Drawing.Point(295, 230);
            this.txt_customerpassword.Name = "txt_customerpassword";
            this.txt_customerpassword.Size = new System.Drawing.Size(210, 41);
            this.txt_customerpassword.TabIndex = 9;
            // 
            // btn_addcustomer
            // 
            this.btn_addcustomer.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcustomer.Location = new System.Drawing.Point(60, 292);
            this.btn_addcustomer.Name = "btn_addcustomer";
            this.btn_addcustomer.Size = new System.Drawing.Size(130, 95);
            this.btn_addcustomer.TabIndex = 10;
            this.btn_addcustomer.Text = "add customer";
            this.btn_addcustomer.UseVisualStyleBackColor = true;
            this.btn_addcustomer.Click += new System.EventHandler(this.btn_addcustomer_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(427, 424);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(129, 107);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cmb_cities
            // 
            this.cmb_cities.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cities.FormattingEnabled = true;
            this.cmb_cities.Location = new System.Drawing.Point(295, 183);
            this.cmb_cities.Name = "cmb_cities";
            this.cmb_cities.Size = new System.Drawing.Size(210, 41);
            this.cmb_cities.TabIndex = 12;
            // 
            // btn_findcustomer
            // 
            this.btn_findcustomer.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findcustomer.Location = new System.Drawing.Point(242, 286);
            this.btn_findcustomer.Name = "btn_findcustomer";
            this.btn_findcustomer.Size = new System.Drawing.Size(112, 107);
            this.btn_findcustomer.TabIndex = 13;
            this.btn_findcustomer.Text = "find customer";
            this.btn_findcustomer.UseVisualStyleBackColor = true;
            this.btn_findcustomer.Click += new System.EventHandler(this.btn_findcustomer_Click);
            // 
            // btn_updatecustomer
            // 
            this.btn_updatecustomer.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatecustomer.Location = new System.Drawing.Point(402, 302);
            this.btn_updatecustomer.Name = "btn_updatecustomer";
            this.btn_updatecustomer.Size = new System.Drawing.Size(201, 91);
            this.btn_updatecustomer.TabIndex = 15;
            this.btn_updatecustomer.Text = "update customer";
            this.btn_updatecustomer.UseVisualStyleBackColor = true;
            this.btn_updatecustomer.Click += new System.EventHandler(this.btn_updatecustomer_Click);
            // 
            // btn_deletecustomer
            // 
            this.btn_deletecustomer.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletecustomer.ForeColor = System.Drawing.Color.Red;
            this.btn_deletecustomer.Location = new System.Drawing.Point(217, 440);
            this.btn_deletecustomer.Name = "btn_deletecustomer";
            this.btn_deletecustomer.Size = new System.Drawing.Size(157, 75);
            this.btn_deletecustomer.TabIndex = 16;
            this.btn_deletecustomer.Text = "delete customer";
            this.btn_deletecustomer.UseVisualStyleBackColor = true;
            this.btn_deletecustomer.Click += new System.EventHandler(this.btn_deletecustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 570);
            this.Controls.Add(this.btn_deletecustomer);
            this.Controls.Add(this.btn_updatecustomer);
            this.Controls.Add(this.btn_findcustomer);
            this.Controls.Add(this.cmb_cities);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_addcustomer);
            this.Controls.Add(this.txt_customerpassword);
            this.Controls.Add(this.txt_customerage);
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.txt_customerid);
            this.Controls.Add(this.lbl_customerpassword);
            this.Controls.Add(this.lbl_customercity);
            this.Controls.Add(this.lbl_customerage);
            this.Controls.Add(this.lbl_customername);
            this.Controls.Add(this.lbl_customerid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customerid;
        private System.Windows.Forms.Label lbl_customername;
        private System.Windows.Forms.Label lbl_customerage;
        private System.Windows.Forms.Label lbl_customercity;
        private System.Windows.Forms.Label lbl_customerpassword;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.TextBox txt_customerage;
        private System.Windows.Forms.TextBox txt_customerpassword;
        private System.Windows.Forms.Button btn_addcustomer;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmb_cities;
        private System.Windows.Forms.Button btn_findcustomer;
        private System.Windows.Forms.Button btn_updatecustomer;
        private System.Windows.Forms.Button btn_deletecustomer;
    }
}

