namespace win_ado_day1_assignment
{
    partial class frm_findorder
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
            this.lbl_orderid = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_itemqty = new System.Windows.Forms.Label();
            this.lbl_itemprice = new System.Windows.Forms.Label();
            this.lbl_orderdate = new System.Windows.Forms.Label();
            this.btn_findorder = new System.Windows.Forms.Button();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.lbl_customeridres = new System.Windows.Forms.Label();
            this.lbl_itemnameres = new System.Windows.Forms.Label();
            this.lbl_itemqtyres = new System.Windows.Forms.Label();
            this.lbl_itempriceres = new System.Windows.Forms.Label();
            this.lbl_orderdateres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_customerid
            // 
            this.lbl_customerid.AutoSize = true;
            this.lbl_customerid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerid.Location = new System.Drawing.Point(76, 60);
            this.lbl_customerid.Name = "lbl_customerid";
            this.lbl_customerid.Size = new System.Drawing.Size(111, 33);
            this.lbl_customerid.TabIndex = 0;
            this.lbl_customerid.Text = "customerid";
            this.lbl_customerid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_orderid
            // 
            this.lbl_orderid.AutoSize = true;
            this.lbl_orderid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderid.Location = new System.Drawing.Point(86, 19);
            this.lbl_orderid.Name = "lbl_orderid";
            this.lbl_orderid.Size = new System.Drawing.Size(129, 33);
            this.lbl_orderid.TabIndex = 1;
            this.lbl_orderid.Text = "enter orderid";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemname.Location = new System.Drawing.Point(86, 99);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(97, 33);
            this.lbl_itemname.TabIndex = 2;
            this.lbl_itemname.Text = "item name";
            // 
            // lbl_itemqty
            // 
            this.lbl_itemqty.AutoSize = true;
            this.lbl_itemqty.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemqty.Location = new System.Drawing.Point(86, 137);
            this.lbl_itemqty.Name = "lbl_itemqty";
            this.lbl_itemqty.Size = new System.Drawing.Size(83, 33);
            this.lbl_itemqty.TabIndex = 3;
            this.lbl_itemqty.Text = "item qty";
            // 
            // lbl_itemprice
            // 
            this.lbl_itemprice.AutoSize = true;
            this.lbl_itemprice.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemprice.Location = new System.Drawing.Point(86, 182);
            this.lbl_itemprice.Name = "lbl_itemprice";
            this.lbl_itemprice.Size = new System.Drawing.Size(93, 33);
            this.lbl_itemprice.TabIndex = 4;
            this.lbl_itemprice.Text = "itemprice";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderdate.Location = new System.Drawing.Point(76, 227);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(103, 33);
            this.lbl_orderdate.TabIndex = 5;
            this.lbl_orderdate.Text = "orderdate";
            // 
            // btn_findorder
            // 
            this.btn_findorder.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findorder.Location = new System.Drawing.Point(386, 136);
            this.btn_findorder.Name = "btn_findorder";
            this.btn_findorder.Size = new System.Drawing.Size(131, 52);
            this.btn_findorder.TabIndex = 6;
            this.btn_findorder.Text = "find order";
            this.btn_findorder.UseVisualStyleBackColor = true;
            this.btn_findorder.Click += new System.EventHandler(this.btn_findorder_Click);
            // 
            // txt_orderid
            // 
            this.txt_orderid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderid.Location = new System.Drawing.Point(243, 27);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(137, 41);
            this.txt_orderid.TabIndex = 7;
            // 
            // lbl_customeridres
            // 
            this.lbl_customeridres.AutoSize = true;
            this.lbl_customeridres.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customeridres.Location = new System.Drawing.Point(240, 80);
            this.lbl_customeridres.Name = "lbl_customeridres";
            this.lbl_customeridres.Size = new System.Drawing.Size(31, 30);
            this.lbl_customeridres.TabIndex = 8;
            this.lbl_customeridres.Text = "---";
            // 
            // lbl_itemnameres
            // 
            this.lbl_itemnameres.AutoSize = true;
            this.lbl_itemnameres.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemnameres.Location = new System.Drawing.Point(240, 110);
            this.lbl_itemnameres.Name = "lbl_itemnameres";
            this.lbl_itemnameres.Size = new System.Drawing.Size(31, 30);
            this.lbl_itemnameres.TabIndex = 9;
            this.lbl_itemnameres.Text = "---";
            // 
            // lbl_itemqtyres
            // 
            this.lbl_itemqtyres.AutoSize = true;
            this.lbl_itemqtyres.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemqtyres.Location = new System.Drawing.Point(240, 148);
            this.lbl_itemqtyres.Name = "lbl_itemqtyres";
            this.lbl_itemqtyres.Size = new System.Drawing.Size(31, 30);
            this.lbl_itemqtyres.TabIndex = 10;
            this.lbl_itemqtyres.Text = "---";
            // 
            // lbl_itempriceres
            // 
            this.lbl_itempriceres.AutoSize = true;
            this.lbl_itempriceres.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itempriceres.Location = new System.Drawing.Point(240, 193);
            this.lbl_itempriceres.Name = "lbl_itempriceres";
            this.lbl_itempriceres.Size = new System.Drawing.Size(31, 30);
            this.lbl_itempriceres.TabIndex = 11;
            this.lbl_itempriceres.Text = "---";
            // 
            // lbl_orderdateres
            // 
            this.lbl_orderdateres.AutoSize = true;
            this.lbl_orderdateres.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderdateres.Location = new System.Drawing.Point(240, 238);
            this.lbl_orderdateres.Name = "lbl_orderdateres";
            this.lbl_orderdateres.Size = new System.Drawing.Size(31, 30);
            this.lbl_orderdateres.TabIndex = 12;
            this.lbl_orderdateres.Text = "---";
            // 
            // frm_findorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 308);
            this.Controls.Add(this.lbl_orderdateres);
            this.Controls.Add(this.lbl_itempriceres);
            this.Controls.Add(this.lbl_itemqtyres);
            this.Controls.Add(this.lbl_itemnameres);
            this.Controls.Add(this.lbl_customeridres);
            this.Controls.Add(this.txt_orderid);
            this.Controls.Add(this.btn_findorder);
            this.Controls.Add(this.lbl_orderdate);
            this.Controls.Add(this.lbl_itemprice);
            this.Controls.Add(this.lbl_itemqty);
            this.Controls.Add(this.lbl_itemname);
            this.Controls.Add(this.lbl_orderid);
            this.Controls.Add(this.lbl_customerid);
            this.Name = "frm_findorder";
            this.Text = "frm_findorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customerid;
        private System.Windows.Forms.Label lbl_orderid;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_itemqty;
        private System.Windows.Forms.Label lbl_itemprice;
        private System.Windows.Forms.Label lbl_orderdate;
        private System.Windows.Forms.Button btn_findorder;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.Label lbl_customeridres;
        private System.Windows.Forms.Label lbl_itemnameres;
        private System.Windows.Forms.Label lbl_itemqtyres;
        private System.Windows.Forms.Label lbl_itempriceres;
        private System.Windows.Forms.Label lbl_orderdateres;
    }
}