namespace PRJCLUMS
{
    partial class frmDailyReports
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
            this.groupList = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupList
            // 
            this.groupList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupList.Controls.Add(this.lblCategory);
            this.groupList.Controls.Add(this.lblCalendar);
            this.groupList.Controls.Add(this.monthCalendar);
            this.groupList.Controls.Add(this.cbSearch);
            this.groupList.Controls.Add(this.lblData);
            this.groupList.Controls.Add(this.btnSearch);
            this.groupList.Controls.Add(this.listView);
            this.groupList.Controls.Add(this.txtSearch);
            this.groupList.Controls.Add(this.btnPrint);
            this.groupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupList.ForeColor = System.Drawing.Color.Gold;
            this.groupList.Location = new System.Drawing.Point(12, 64);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(1160, 539);
            this.groupList.TabIndex = 6;
            this.groupList.TabStop = false;
            this.groupList.Text = "Entries";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCategory.Location = new System.Drawing.Point(918, 203);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(108, 13);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Categorial Search";
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.BackColor = System.Drawing.Color.Transparent;
            this.lblCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCalendar.Location = new System.Drawing.Point(918, 16);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(101, 13);
            this.lblCalendar.TabIndex = 15;
            this.lblCalendar.Text = "Calendar Search";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(921, 32);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 14;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "By Item Number",
            "By Customer",
            "By User ID"});
            this.cbSearch.Location = new System.Drawing.Point(1002, 219);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(146, 21);
            this.cbSearch.TabIndex = 12;
            this.cbSearch.Text = "           (select)";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Gold;
            this.lblData.Location = new System.Drawing.Point(867, 16);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data: 0";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Maroon;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gold;
            this.btnSearch.Location = new System.Drawing.Point(921, 219);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeader11});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(6, 32);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(909, 487);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Trx Ctr";
            this.columnHeader8.Width = 65;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Trx Date";
            this.columnHeader9.Width = 93;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Number";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            this.columnHeader6.Width = 58;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total Price";
            this.columnHeader7.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Customer";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "UserID";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(921, 248);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Maroon;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Gold;
            this.btnPrint.Location = new System.Drawing.Point(982, 274);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 48);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "GENERATE REPORT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lnkClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 52);
            this.panel1.TabIndex = 5;
            // 
            // lnkClose
            // 
            this.lnkClose.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkClose.AutoSize = true;
            this.lnkClose.BackColor = System.Drawing.Color.Transparent;
            this.lnkClose.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.ForeColor = System.Drawing.Color.Gold;
            this.lnkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkClose.LinkColor = System.Drawing.Color.Gold;
            this.lnkClose.Location = new System.Drawing.Point(1151, 9);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(21, 22);
            this.lnkClose.TabIndex = 2;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "X";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "DAILY AND WEEKLY REPORTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 12);
            this.panel2.TabIndex = 0;
            // 
            // frmDailyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1184, 615);
            this.ControlBox = false;
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.panel1);
            this.Name = "frmDailyReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cyril\'s Garden Flower Shop Sales Management System";
            this.Load += new System.EventHandler(this.frmDailyReports_Load);
            this.groupList.ResumeLayout(false);
            this.groupList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}