namespace PRJCLUMS
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adduserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageusersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageinventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.manageCategoriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Navy;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblUser});
            this.statusStrip.Location = new System.Drawing.Point(0, 343);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(610, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 17);
            this.lblTime.Text = "12:00:00 AM";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 17);
            this.lblUser.Text = "          User: ";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Navy;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(610, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adduserToolStripMenuItem,
            this.manageusersToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // adduserToolStripMenuItem
            // 
            this.adduserToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.adduserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adduserToolStripMenuItem.Name = "adduserToolStripMenuItem";
            this.adduserToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.adduserToolStripMenuItem.Text = "Add User...";
            this.adduserToolStripMenuItem.Click += new System.EventHandler(this.adduserToolStripMenuItem_Click);
            // 
            // manageusersToolStripMenuItem
            // 
            this.manageusersToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.manageusersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageusersToolStripMenuItem.Name = "manageusersToolStripMenuItem";
            this.manageusersToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.manageusersToolStripMenuItem.Text = "Manage Users...";
            this.manageusersToolStripMenuItem.Click += new System.EventHandler(this.manageusersToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additemToolStripMenuItem,
            this.manageinventoryToolStripMenuItem,
            this.manageCategoriesToolStripMenuItem1});
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // additemToolStripMenuItem
            // 
            this.additemToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.additemToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.additemToolStripMenuItem.Name = "additemToolStripMenuItem";
            this.additemToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.additemToolStripMenuItem.Text = "Add Item...";
            this.additemToolStripMenuItem.Click += new System.EventHandler(this.additemToolStripMenuItem_Click);
            // 
            // manageinventoryToolStripMenuItem
            // 
            this.manageinventoryToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.manageinventoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageinventoryToolStripMenuItem.Name = "manageinventoryToolStripMenuItem";
            this.manageinventoryToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.manageinventoryToolStripMenuItem.Text = "Manage Inventory...";
            this.manageinventoryToolStripMenuItem.Click += new System.EventHandler(this.manageinventoryToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billingToolStripMenuItem,
            this.inquiryToolStripMenuItem});
            this.transactionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.billingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.billingToolStripMenuItem.Text = "Billing...";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // inquiryToolStripMenuItem
            // 
            this.inquiryToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.inquiryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inquiryToolStripMenuItem.Name = "inquiryToolStripMenuItem";
            this.inquiryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inquiryToolStripMenuItem.Text = "Inquiry...";
            this.inquiryToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportToolStripMenuItem,
            this.itemReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.salesReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.salesReportToolStripMenuItem.Text = "Sales Reports";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.weeklyToolStripMenuItem_Click);
            // 
            // itemReportsToolStripMenuItem
            // 
            this.itemReportsToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.itemReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.itemReportsToolStripMenuItem.Name = "itemReportsToolStripMenuItem";
            this.itemReportsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.itemReportsToolStripMenuItem.Text = "Item Reports";
            this.itemReportsToolStripMenuItem.Click += new System.EventHandler(this.itemReportsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.toolsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toolsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem1.Text = "Tools";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.notepadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.calculatorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.toolsToolStripMenuItem.Text = "Logout";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // manageCategoriesToolStripMenuItem1
            // 
            this.manageCategoriesToolStripMenuItem1.BackColor = System.Drawing.Color.Navy;
            this.manageCategoriesToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.manageCategoriesToolStripMenuItem1.Name = "manageCategoriesToolStripMenuItem1";
            this.manageCategoriesToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.manageCategoriesToolStripMenuItem1.Text = "Manage Categories...";
            this.manageCategoriesToolStripMenuItem1.Click += new System.EventHandler(this.manageCategoriesToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PRJCLUMS.Properties.Resources.minimalistic_desktop_1920x1200_hd_wallpaper_618062;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 365);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Cyril\'s Garden Plant & Flower Shop Sales Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMDI_FormClosed);
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adduserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageusersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageinventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCategoriesToolStripMenuItem1;
    }
}