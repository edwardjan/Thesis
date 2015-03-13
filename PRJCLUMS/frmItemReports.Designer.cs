namespace PRJCLUMS
{
    partial class frmItemReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemReports));
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.chkBxShowAll = new System.Windows.Forms.CheckBox();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupList.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ITEM REPORTS";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupList);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1141, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item Reports";
            // 
            // groupList
            // 
            this.groupList.BackColor = System.Drawing.Color.Transparent;
            this.groupList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupList.Controls.Add(this.chkBxShowAll);
            this.groupList.Controls.Add(this.lblCalendar);
            this.groupList.Controls.Add(this.btnPrint);
            this.groupList.Controls.Add(this.monthCalendar);
            this.groupList.Controls.Add(this.listView);
            this.groupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupList.ForeColor = System.Drawing.Color.Black;
            this.groupList.Location = new System.Drawing.Point(3, 3);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(1135, 459);
            this.groupList.TabIndex = 7;
            this.groupList.TabStop = false;
            this.groupList.Text = "Entries";
            // 
            // chkBxShowAll
            // 
            this.chkBxShowAll.AutoSize = true;
            this.chkBxShowAll.Checked = true;
            this.chkBxShowAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxShowAll.Location = new System.Drawing.Point(899, 244);
            this.chkBxShowAll.Name = "chkBxShowAll";
            this.chkBxShowAll.Size = new System.Drawing.Size(81, 19);
            this.chkBxShowAll.TabIndex = 29;
            this.chkBxShowAll.Text = "Show All";
            this.chkBxShowAll.UseVisualStyleBackColor = true;
            this.chkBxShowAll.CheckedChanged += new System.EventHandler(this.chkBxShowAll_CheckedChanged);
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.BackColor = System.Drawing.Color.Transparent;
            this.lblCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCalendar.Location = new System.Drawing.Point(896, 63);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(114, 15);
            this.lblCalendar.TabIndex = 17;
            this.lblCalendar.Text = "Calendar Search";
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
            this.btnPrint.Location = new System.Drawing.Point(899, 33);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(220, 23);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "GENERATE REPORT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Enabled = false;
            this.monthCalendar.Location = new System.Drawing.Point(898, 79);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 16;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
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
            this.columnHeader13});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(6, 33);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(885, 420);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Item No";
            this.columnHeader8.Width = 89;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Item Name";
            this.columnHeader9.Width = 209;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Category";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Description";
            this.columnHeader10.Width = 257;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Price";
            this.columnHeader11.Width = 105;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Stock";
            this.columnHeader12.Width = 116;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Item Sold";
            this.columnHeader13.Width = 95;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 493);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // frmItemReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PRJCLUMS.Properties.Resources.Simple_and_elegant_abstract_Wallpaper_HD_2560x1440;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 546);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemReports";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cyril\'s Garden Plant & Flower Shop Sales Management System";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupList.ResumeLayout(false);
            this.groupList.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox chkBxShowAll;
    }
}