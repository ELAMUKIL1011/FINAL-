namespace win_ado_day1_assignment
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
            this.lbl_orderid = new System.Windows.Forms.Label();
            this.lbl_customerid = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.lbl_itemqty = new System.Windows.Forms.Label();
            this.lbl_itemprice = new System.Windows.Forms.Label();
            this.lbl_orderdate = new System.Windows.Forms.Label();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.txt_itemprice = new System.Windows.Forms.TextBox();
            this.txt_orderdate = new System.Windows.Forms.TextBox();
            this.cmb_itemname = new System.Windows.Forms.ComboBox();
            this.cmb_itemquantity = new System.Windows.Forms.ComboBox();
            this.btn_placeorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_orderid
            // 
            this.lbl_orderid.AutoSize = true;
            this.lbl_orderid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderid.Location = new System.Drawing.Point(121, 20);
            this.lbl_orderid.Name = "lbl_orderid";
            this.lbl_orderid.Size = new System.Drawing.Size(92, 33);
            this.lbl_orderid.TabIndex = 0;
            this.lbl_orderid.Text = "order id";
            // 
            // lbl_customerid
            // 
            this.lbl_customerid.AutoSize = true;
            this.lbl_customerid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerid.Location = new System.Drawing.Point(87, 71);
            this.lbl_customerid.Name = "lbl_customerid";
            this.lbl_customerid.Size = new System.Drawing.Size(126, 33);
            this.lbl_customerid.TabIndex = 1;
            this.lbl_customerid.Text = "customer id";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.Location = new System.Drawing.Point(143, 127);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(53, 33);
            this.lbl_itemid.TabIndex = 2;
            this.lbl_itemid.Text = "item";
            // 
            // lbl_itemqty
            // 
            this.lbl_itemqty.AutoSize = true;
            this.lbl_itemqty.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemqty.Location = new System.Drawing.Point(71, 180);
            this.lbl_itemqty.Name = "lbl_itemqty";
            this.lbl_itemqty.Size = new System.Drawing.Size(142, 33);
            this.lbl_itemqty.TabIndex = 3;
            this.lbl_itemqty.Text = "item quantity";
            // 
            // lbl_itemprice
            // 
            this.lbl_itemprice.AutoSize = true;
            this.lbl_itemprice.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemprice.Location = new System.Drawing.Point(121, 224);
            this.lbl_itemprice.Name = "lbl_itemprice";
            this.lbl_itemprice.Size = new System.Drawing.Size(102, 33);
            this.lbl_itemprice.TabIndex = 4;
            this.lbl_itemprice.Text = "itemprice";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderdate.Location = new System.Drawing.Point(101, 271);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(122, 33);
            this.lbl_orderdate.TabIndex = 5;
            this.lbl_orderdate.Text = "order date ";
            // 
            // txt_orderid
            // 
            this.txt_orderid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderid.Location = new System.Drawing.Point(244, 12);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(169, 41);
            this.txt_orderid.TabIndex = 6;
            // 
            // txt_customerid
            // 
            this.txt_customerid.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerid.Location = new System.Drawing.Point(236, 71);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(177, 41);
            this.txt_customerid.TabIndex = 7;
            // 
            // txt_itemprice
            // 
            this.txt_itemprice.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemprice.Location = new System.Drawing.Point(236, 221);
            this.txt_itemprice.Name = "txt_itemprice";
            this.txt_itemprice.Size = new System.Drawing.Size(100, 41);
            this.txt_itemprice.TabIndex = 8;
            // 
            // txt_orderdate
            // 
            this.txt_orderdate.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderdate.Location = new System.Drawing.Point(236, 268);
            this.txt_orderdate.Name = "txt_orderdate";
            this.txt_orderdate.Size = new System.Drawing.Size(201, 41);
            this.txt_orderdate.TabIndex = 9;
            // 
            // cmb_itemname
            // 
            this.cmb_itemname.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemname.FormattingEnabled = true;
            this.cmb_itemname.Location = new System.Drawing.Point(236, 119);
            this.cmb_itemname.Name = "cmb_itemname";
            this.cmb_itemname.Size = new System.Drawing.Size(177, 41);
            this.cmb_itemname.TabIndex = 10;
            this.cmb_itemname.SelectedIndexChanged += new System.EventHandler(this.cmb_itemname_SelectedIndexChanged);
            // 
            // cmb_itemquantity
            // 
            this.cmb_itemquantity.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemquantity.FormattingEnabled = true;
            this.cmb_itemquantity.Location = new System.Drawing.Point(236, 172);
            this.cmb_itemquantity.Name = "cmb_itemquantity";
            this.cmb_itemquantity.Size = new System.Drawing.Size(121, 41);
            this.cmb_itemquantity.TabIndex = 11;
            this.cmb_itemquantity.SelectedIndexChanged += new System.EventHandler(this.cmb_itemquantity_SelectedIndexChanged);
            // 
            // btn_placeorder
            // 
            this.btn_placeorder.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_placeorder.Location = new System.Drawing.Point(469, 16);
            this.btn_placeorder.Name = "btn_placeorder";
            this.btn_placeorder.Size = new System.Drawing.Size(112, 148);
            this.btn_placeorder.TabIndex = 12;
            this.btn_placeorder.Text = "place order";
            this.btn_placeorder.UseVisualStyleBackColor = true;
            this.btn_placeorder.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 402);
            this.Controls.Add(this.btn_placeorder);
            this.Controls.Add(this.cmb_itemquantity);
            this.Controls.Add(this.cmb_itemname);
            this.Controls.Add(this.txt_orderdate);
            this.Controls.Add(this.txt_itemprice);
            this.Controls.Add(this.txt_customerid);
            this.Controls.Add(this.txt_orderid);
            this.Controls.Add(this.lbl_orderdate);
            this.Controls.Add(this.lbl_itemprice);
            this.Controls.Add(this.lbl_itemqty);
            this.Controls.Add(this.lbl_itemid);
            this.Controls.Add(this.lbl_customerid);
            this.Controls.Add(this.lbl_orderid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orderid;
        private System.Windows.Forms.Label lbl_customerid;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Label lbl_itemqty;
        private System.Windows.Forms.Label lbl_itemprice;
        private System.Windows.Forms.Label lbl_orderdate;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.TextBox txt_itemprice;
        private System.Windows.Forms.TextBox txt_orderdate;
        private System.Windows.Forms.ComboBox cmb_itemname;
        private System.Windows.Forms.ComboBox cmb_itemquantity;
        private System.Windows.Forms.Button btn_placeorder;
    }
}

