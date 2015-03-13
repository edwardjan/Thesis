namespace PRJCLUMS
{
    partial class frmBillInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillInquiry));
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupCart = new System.Windows.Forms.GroupBox();
            this.tbxNetSales = new System.Windows.Forms.TextBox();
            this.tbxTaxPayable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTotalSales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblData = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBillNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "INVOICE INQUIRY";
            // 
            // groupCart
            // 
            this.groupCart.BackColor = System.Drawing.Color.Transparent;
            this.groupCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupCart.Controls.Add(this.tbxNetSales);
            this.groupCart.Controls.Add(this.tbxTaxPayable);
            this.groupCart.Controls.Add(this.label6);
            this.groupCart.Controls.Add(this.label5);
            this.groupCart.Controls.Add(this.tbxAddress);
            this.groupCart.Controls.Add(this.label3);
            this.groupCart.Controls.Add(this.tbxCustomerName);
            this.groupCart.Controls.Add(this.label2);
            this.groupCart.Controls.Add(this.tbxTotalSales);
            this.groupCart.Controls.Add(this.label1);
            this.groupCart.Controls.Add(this.lsvCart);
            this.groupCart.Controls.Add(this.lblData);
            this.groupCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCart.ForeColor = System.Drawing.Color.Black;
            this.groupCart.Location = new System.Drawing.Point(7, 90);
            this.groupCart.Name = "groupCart";
            this.groupCart.Size = new System.Drawing.Size(651, 479);
            this.groupCart.TabIndex = 12;
            this.groupCart.TabStop = false;
            this.groupCart.Text = "Bill Information";
            // 
            // tbxNetSales
            // 
            this.tbxNetSales.BackColor = System.Drawing.Color.White;
            this.tbxNetSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbxNetSales.Location = new System.Drawing.Point(557, 394);
            this.tbxNetSales.Name = "tbxNetSales";
            this.tbxNetSales.ReadOnly = true;
            this.tbxNetSales.Size = new System.Drawing.Size(79, 20);
            this.tbxNetSales.TabIndex = 38;
            this.tbxNetSales.Text = "0.00";
            this.tbxNetSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTaxPayable
            // 
            this.tbxTaxPayable.BackColor = System.Drawing.Color.White;
            this.tbxTaxPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbxTaxPayable.Location = new System.Drawing.Point(557, 416);
            this.tbxTaxPayable.Name = "tbxTaxPayable";
            this.tbxTaxPayable.ReadOnly = true;
            this.tbxTaxPayable.Size = new System.Drawing.Size(79, 20);
            this.tbxTaxPayable.TabIndex = 37;
            this.tbxTaxPayable.Text = "0.00";
            this.tbxTaxPayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(452, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Net Sales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(385, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tax Payable (12%):";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(112, 61);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.ReadOnly = true;
            this.tbxAddress.Size = new System.Drawing.Size(329, 21);
            this.tbxAddress.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Address:";
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Location = new System.Drawing.Point(112, 29);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.ReadOnly = true;
            this.tbxCustomerName.Size = new System.Drawing.Size(207, 21);
            this.tbxCustomerName.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Bill To:";
            // 
            // tbxTotalSales
            // 
            this.tbxTotalSales.BackColor = System.Drawing.Color.White;
            this.tbxTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbxTotalSales.Location = new System.Drawing.Point(557, 438);
            this.tbxTotalSales.Name = "tbxTotalSales";
            this.tbxTotalSales.ReadOnly = true;
            this.tbxTotalSales.Size = new System.Drawing.Size(79, 20);
            this.tbxTotalSales.TabIndex = 30;
            this.tbxTotalSales.Text = "0.00";
            this.tbxTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(440, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Total Sales:";
            // 
            // lsvCart
            // 
            this.lsvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCart.FullRowSelect = true;
            this.lsvCart.GridLines = true;
            this.lsvCart.Location = new System.Drawing.Point(24, 87);
            this.lsvCart.Name = "lsvCart";
            this.lsvCart.Size = new System.Drawing.Size(612, 293);
            this.lsvCart.TabIndex = 3;
            this.lsvCart.UseCompatibleStateImageBehavior = false;
            this.lsvCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Number";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 139;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total Price";
            this.columnHeader7.Width = 88;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(583, 69);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 15);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data: 0";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Navy;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(526, 575);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 46);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "GENERATE REPORT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Enter Invoice No:";
            // 
            // tbxBillNo
            // 
            this.tbxBillNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxBillNo.Location = new System.Drawing.Point(134, 53);
            this.tbxBillNo.Name = "tbxBillNo";
            this.tbxBillNo.Size = new System.Drawing.Size(99, 20);
            this.tbxBillNo.TabIndex = 35;
            this.tbxBillNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBillNo_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(239, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 20);
            this.button1.TabIndex = 36;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBillInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PRJCLUMS.Properties.Resources.Simple_and_elegant_abstract_Wallpaper_HD_2560x1440;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 627);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxBillNo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupCart);
            this.Controls.Add(this.btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBillInquiry";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyril\'s Garden Plant & Flower Shop Sales Management System";
            this.groupCart.ResumeLayout(false);
            this.groupCart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupCart;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListView lsvCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox tbxTotalSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxBillNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxNetSales;
        private System.Windows.Forms.TextBox tbxTaxPayable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}