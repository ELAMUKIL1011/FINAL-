namespace assignment_windows_day5
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
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.lbl_customername = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.lbl_itemquantity = new System.Windows.Forms.Label();
            this.txt_itemquantity = new System.Windows.Forms.TextBox();
            this.lbl_itemprice = new System.Windows.Forms.Label();
            this.txt_itemprice = new System.Windows.Forms.TextBox();
            this.lbl_deliveryaddress = new System.Windows.Forms.Label();
            this.txt_deliveryaddress = new System.Windows.Forms.TextBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_paymentoption = new System.Windows.Forms.Label();
            this.rdb_COD = new System.Windows.Forms.RadioButton();
            this.rdb_NET = new System.Windows.Forms.RadioButton();
            this.rdb_PAYTM = new System.Windows.Forms.RadioButton();
            this.btn_placeorder = new System.Windows.Forms.Button();
            this.btn_showorders = new System.Windows.Forms.Button();
            this.dg_orders = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(179, 18);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(225, 20);
            this.txt_customername.TabIndex = 0;
            // 
            // lbl_customername
            // 
            this.lbl_customername.AutoSize = true;
            this.lbl_customername.Location = new System.Drawing.Point(46, 25);
            this.lbl_customername.Name = "lbl_customername";
            this.lbl_customername.Size = new System.Drawing.Size(99, 13);
            this.lbl_customername.TabIndex = 1;
            this.lbl_customername.Text = "CUSTOMERNAME";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Location = new System.Drawing.Point(73, 65);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(67, 13);
            this.lbl_itemname.TabIndex = 2;
            this.lbl_itemname.Text = "ITEM NAME";
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(179, 62);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(225, 20);
            this.txt_itemname.TabIndex = 3;
            // 
            // lbl_itemquantity
            // 
            this.lbl_itemquantity.AutoSize = true;
            this.lbl_itemquantity.Location = new System.Drawing.Point(54, 104);
            this.lbl_itemquantity.Name = "lbl_itemquantity";
            this.lbl_itemquantity.Size = new System.Drawing.Size(91, 13);
            this.lbl_itemquantity.TabIndex = 4;
            this.lbl_itemquantity.Text = "ITEM QUANTITY";
            // 
            // txt_itemquantity
            // 
            this.txt_itemquantity.Location = new System.Drawing.Point(179, 97);
            this.txt_itemquantity.Name = "txt_itemquantity";
            this.txt_itemquantity.Size = new System.Drawing.Size(219, 20);
            this.txt_itemquantity.TabIndex = 5;
            // 
            // lbl_itemprice
            // 
            this.lbl_itemprice.AutoSize = true;
            this.lbl_itemprice.Location = new System.Drawing.Point(77, 145);
            this.lbl_itemprice.Name = "lbl_itemprice";
            this.lbl_itemprice.Size = new System.Drawing.Size(68, 13);
            this.lbl_itemprice.TabIndex = 6;
            this.lbl_itemprice.Text = "ITEM PRICE";
            // 
            // txt_itemprice
            // 
            this.txt_itemprice.Location = new System.Drawing.Point(179, 145);
            this.txt_itemprice.Name = "txt_itemprice";
            this.txt_itemprice.Size = new System.Drawing.Size(188, 20);
            this.txt_itemprice.TabIndex = 7;
            // 
            // lbl_deliveryaddress
            // 
            this.lbl_deliveryaddress.AutoSize = true;
            this.lbl_deliveryaddress.Location = new System.Drawing.Point(30, 225);
            this.lbl_deliveryaddress.Name = "lbl_deliveryaddress";
            this.lbl_deliveryaddress.Size = new System.Drawing.Size(115, 13);
            this.lbl_deliveryaddress.TabIndex = 8;
            this.lbl_deliveryaddress.Text = "DELIVERY ADDRESS";
            // 
            // txt_deliveryaddress
            // 
            this.txt_deliveryaddress.Location = new System.Drawing.Point(179, 225);
            this.txt_deliveryaddress.Name = "txt_deliveryaddress";
            this.txt_deliveryaddress.Size = new System.Drawing.Size(197, 20);
            this.txt_deliveryaddress.TabIndex = 9;
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(179, 183);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(121, 21);
            this.cmb_city.TabIndex = 10;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(109, 183);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(31, 13);
            this.lbl_city.TabIndex = 11;
            this.lbl_city.Text = "CITY";
            // 
            // lbl_paymentoption
            // 
            this.lbl_paymentoption.AutoSize = true;
            this.lbl_paymentoption.Location = new System.Drawing.Point(339, 191);
            this.lbl_paymentoption.Name = "lbl_paymentoption";
            this.lbl_paymentoption.Size = new System.Drawing.Size(103, 13);
            this.lbl_paymentoption.TabIndex = 12;
            this.lbl_paymentoption.Text = "PAYMENT OPTION";
            // 
            // rdb_COD
            // 
            this.rdb_COD.AutoSize = true;
            this.rdb_COD.Location = new System.Drawing.Point(481, 191);
            this.rdb_COD.Name = "rdb_COD";
            this.rdb_COD.Size = new System.Drawing.Size(129, 17);
            this.rdb_COD.TabIndex = 13;
            this.rdb_COD.TabStop = true;
            this.rdb_COD.Text = "CASH ON DELIVERY";
            this.rdb_COD.UseVisualStyleBackColor = true;
            // 
            // rdb_NET
            // 
            this.rdb_NET.AutoSize = true;
            this.rdb_NET.Location = new System.Drawing.Point(616, 189);
            this.rdb_NET.Name = "rdb_NET";
            this.rdb_NET.Size = new System.Drawing.Size(98, 17);
            this.rdb_NET.TabIndex = 14;
            this.rdb_NET.TabStop = true;
            this.rdb_NET.Text = "NET BANKING";
            this.rdb_NET.UseVisualStyleBackColor = true;
            // 
            // rdb_PAYTM
            // 
            this.rdb_PAYTM.AutoSize = true;
            this.rdb_PAYTM.Location = new System.Drawing.Point(522, 214);
            this.rdb_PAYTM.Name = "rdb_PAYTM";
            this.rdb_PAYTM.Size = new System.Drawing.Size(109, 17);
            this.rdb_PAYTM.TabIndex = 15;
            this.rdb_PAYTM.TabStop = true;
            this.rdb_PAYTM.Text = "PAYTM WALLET";
            this.rdb_PAYTM.UseVisualStyleBackColor = true;
            this.rdb_PAYTM.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btn_placeorder
            // 
            this.btn_placeorder.Location = new System.Drawing.Point(488, 81);
            this.btn_placeorder.Name = "btn_placeorder";
            this.btn_placeorder.Size = new System.Drawing.Size(204, 59);
            this.btn_placeorder.TabIndex = 16;
            this.btn_placeorder.Text = "CLICK TO PLACE ORDER";
            this.btn_placeorder.UseVisualStyleBackColor = true;
            this.btn_placeorder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_showorders
            // 
            this.btn_showorders.Location = new System.Drawing.Point(33, 288);
            this.btn_showorders.Name = "btn_showorders";
            this.btn_showorders.Size = new System.Drawing.Size(75, 23);
            this.btn_showorders.TabIndex = 17;
            this.btn_showorders.Text = "showorders";
            this.btn_showorders.UseVisualStyleBackColor = true;
            this.btn_showorders.Click += new System.EventHandler(this.btn_showorders_Click);
            // 
            // dg_orders
            // 
            this.dg_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_orders.Location = new System.Drawing.Point(151, 297);
            this.dg_orders.Name = "dg_orders";
            this.dg_orders.Size = new System.Drawing.Size(674, 150);
            this.dg_orders.TabIndex = 18;
            this.dg_orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_orders_CellContentClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(488, 20);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(197, 23);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "CLICK TO CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 497);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dg_orders);
            this.Controls.Add(this.btn_showorders);
            this.Controls.Add(this.btn_placeorder);
            this.Controls.Add(this.rdb_PAYTM);
            this.Controls.Add(this.rdb_NET);
            this.Controls.Add(this.rdb_COD);
            this.Controls.Add(this.lbl_paymentoption);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.txt_deliveryaddress);
            this.Controls.Add(this.lbl_deliveryaddress);
            this.Controls.Add(this.txt_itemprice);
            this.Controls.Add(this.lbl_itemprice);
            this.Controls.Add(this.txt_itemquantity);
            this.Controls.Add(this.lbl_itemquantity);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.lbl_itemname);
            this.Controls.Add(this.lbl_customername);
            this.Controls.Add(this.txt_customername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label lbl_customername;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.Label lbl_itemquantity;
        private System.Windows.Forms.TextBox txt_itemquantity;
        private System.Windows.Forms.Label lbl_itemprice;
        private System.Windows.Forms.TextBox txt_itemprice;
        private System.Windows.Forms.Label lbl_deliveryaddress;
        private System.Windows.Forms.TextBox txt_deliveryaddress;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_paymentoption;
        private System.Windows.Forms.RadioButton rdb_COD;
        private System.Windows.Forms.RadioButton rdb_NET;
        private System.Windows.Forms.RadioButton rdb_PAYTM;
        private System.Windows.Forms.Button btn_placeorder;
        private System.Windows.Forms.Button btn_showorders;
        private System.Windows.Forms.DataGridView dg_orders;
        private System.Windows.Forms.Button btn_clear;
    }
}

