namespace PRJCLUMS
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDailyWeekly = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpByMonth = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrintYearly = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtpByYear = new System.Windows.Forms.DateTimePicker();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupList.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "SALES REPORTS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1166, 493);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupList);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1158, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daily & Weekly Reports";
            // 
            // groupList
            // 
            this.groupList.BackColor = System.Drawing.Color.Transparent;
            this.groupList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupList.Controls.Add(this.lblCategory);
            this.groupList.Controls.Add(this.lblCalendar);
            this.groupList.Controls.Add(this.monthCalendar);
            this.groupList.Controls.Add(this.cbSearch);
            this.groupList.Controls.Add(this.lblData);
            this.groupList.Controls.Add(this.button1);
            this.groupList.Controls.Add(this.listView);
            this.groupList.Controls.Add(this.txtSearch);
            this.groupList.Controls.Add(this.btnDailyWeekly);
            this.groupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupList.ForeColor = System.Drawing.Color.Black;
            this.groupList.Location = new System.Drawing.Point(3, 3);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(1152, 459);
            this.groupList.TabIndex = 7;
            this.groupList.TabStop = false;
            this.groupList.Text = "Entries";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCategory.Location = new System.Drawing.Point(918, 203);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(122, 15);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Categorial Search";
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.BackColor = System.Drawing.Color.Transparent;
            this.lblCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCalendar.Location = new System.Drawing.Point(918, 16);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(114, 15);
            this.lblCalendar.TabIndex = 15;
            this.lblCalendar.Text = "Calendar Search";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(923, 32);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 14;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "By Item Name",
            "By Customer",
            "By User"});
            this.cbSearch.Location = new System.Drawing.Point(1002, 219);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(146, 23);
            this.cbSearch.TabIndex = 12;
            this.cbSearch.Text = "           (select)";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(859, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 15);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data: 0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(921, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSearchDailyWeekly_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader18,
            this.columnHeader19});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(6, 32);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(909, 421);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Invoice No";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Item Number";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Item Name";
            this.columnHeader10.Width = 144;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Category";
            this.columnHeader11.Width = 99;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Description";
            this.columnHeader12.Width = 116;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Price";
            this.columnHeader13.Width = 75;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Quantity";
            this.columnHeader14.Width = 77;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Total Price";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader15.Width = 94;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Customer";
            this.columnHeader18.Width = 125;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "User";
            this.columnHeader19.Width = 116;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(921, 248);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // btnDailyWeekly
            // 
            this.btnDailyWeekly.BackColor = System.Drawing.Color.Navy;
            this.btnDailyWeekly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDailyWeekly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailyWeekly.Enabled = false;
            this.btnDailyWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDailyWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyWeekly.ForeColor = System.Drawing.Color.White;
            this.btnDailyWeekly.Location = new System.Drawing.Point(982, 274);
            this.btnDailyWeekly.Name = "btnDailyWeekly";
            this.btnDailyWeekly.Size = new System.Drawing.Size(105, 48);
            this.btnDailyWeekly.TabIndex = 8;
            this.btnDailyWeekly.Text = "GENERATE REPORT";
            this.btnDailyWeekly.UseVisualStyleBackColor = false;
            this.btnDailyWeekly.Click += new System.EventHandler(this.btnPrintDaily_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btnPrint);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.dtpByMonth);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1158, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monthly Reports";
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
            this.btnPrint.Location = new System.Drawing.Point(922, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(220, 23);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "GENERATE REPORT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrintMontly_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(164, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpByMonth
            // 
            this.dtpByMonth.CustomFormat = "MMMM - yyyy";
            this.dtpByMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpByMonth.Location = new System.Drawing.Point(18, 10);
            this.dtpByMonth.Name = "dtpByMonth";
            this.dtpByMonth.ShowUpDown = true;
            this.dtpByMonth.Size = new System.Drawing.Size(140, 21);
            this.dtpByMonth.TabIndex = 25;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(18, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1124, 426);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 205;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "User";
            this.columnHeader16.Width = 211;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Customer";
            this.columnHeader17.Width = 303;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Sold";
            this.columnHeader2.Width = 194;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Due";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 206;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.btnPrintYearly);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.dtpByYear);
            this.tabPage3.Controls.Add(this.listView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1158, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yearly Reports";
            // 
            // btnPrintYearly
            // 
            this.btnPrintYearly.BackColor = System.Drawing.Color.Navy;
            this.btnPrintYearly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrintYearly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintYearly.Enabled = false;
            this.btnPrintYearly.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintYearly.ForeColor = System.Drawing.Color.White;
            this.btnPrintYearly.Location = new System.Drawing.Point(922, 9);
            this.btnPrintYearly.Name = "btnPrintYearly";
            this.btnPrintYearly.Size = new System.Drawing.Size(220, 23);
            this.btnPrintYearly.TabIndex = 26;
            this.btnPrintYearly.Text = "GENERATE REPORT";
            this.btnPrintYearly.UseVisualStyleBackColor = false;
            this.btnPrintYearly.Click += new System.EventHandler(this.btnPrintYearly_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(157, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "SEARCH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtpByYear
            // 
            this.dtpByYear.CustomFormat = "yyyy";
            this.dtpByYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpByYear.Location = new System.Drawing.Point(19, 12);
            this.dtpByYear.Name = "dtpByYear";
            this.dtpByYear.ShowUpDown = true;
            this.dtpByYear.Size = new System.Drawing.Size(131, 21);
            this.dtpByYear.TabIndex = 24;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(19, 37);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1123, 423);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Month";
            this.columnHeader4.Width = 347;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item Sold";
            this.columnHeader5.Width = 365;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Amount Due";
            this.columnHeader6.Width = 406;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PRJCLUMS.Properties.Resources.Simple_and_elegant_abstract_Wallpaper_HD_2560x1440;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 546);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cyril\'s Garden Plant & Flower Shop Sales Management System";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupList.ResumeLayout(false);
            this.groupList.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpByMonth;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnPrintYearly;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtpByYear;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDailyWeekly;
    }
}