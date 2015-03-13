namespace PRJCLUMS
{
    partial class frmViewCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCategory));
            this.groupList = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CStat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblData = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupList2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblData2 = new System.Windows.Forms.Label();
            this.groupList.SuspendLayout();
            this.groupList2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupList
            // 
            this.groupList.BackColor = System.Drawing.Color.Transparent;
            this.groupList.Controls.Add(this.btnRefresh);
            this.groupList.Controls.Add(this.btnSearch);
            this.groupList.Controls.Add(this.txtSearch);
            this.groupList.Controls.Add(this.btnAdd);
            this.groupList.Controls.Add(this.btnDelete);
            this.groupList.Controls.Add(this.btnEdit);
            this.groupList.Controls.Add(this.listView);
            this.groupList.Controls.Add(this.lblData);
            this.groupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupList.ForeColor = System.Drawing.Color.Black;
            this.groupList.Location = new System.Drawing.Point(12, 47);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(759, 186);
            this.groupList.TabIndex = 6;
            this.groupList.TabStop = false;
            this.groupList.Text = "List of Main Categories";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Navy;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(399, 143);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(24, 143);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.TextChanged += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(105, 145);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Navy;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(481, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Navy;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(643, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DEACTIVATE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Navy;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(562, 143);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.CName,
            this.CDesc,
            this.CStat});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(24, 32);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(716, 105);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Click += new System.EventHandler(this.listView_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // CName
            // 
            this.CName.Text = "Name";
            this.CName.Width = 232;
            // 
            // CDesc
            // 
            this.CDesc.Text = "Description";
            this.CDesc.Width = 326;
            // 
            // CStat
            // 
            this.CStat.Text = "Status";
            this.CStat.Width = 154;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(687, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 15);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data: 0";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "CATEGORY MANAGEMENT";
            // 
            // groupList2
            // 
            this.groupList2.BackColor = System.Drawing.Color.Transparent;
            this.groupList2.Controls.Add(this.btnRefresh2);
            this.groupList2.Controls.Add(this.btnSearch2);
            this.groupList2.Controls.Add(this.txtSearch2);
            this.groupList2.Controls.Add(this.btnAdd2);
            this.groupList2.Controls.Add(this.btnDelete2);
            this.groupList2.Controls.Add(this.btnEdit2);
            this.groupList2.Controls.Add(this.listView2);
            this.groupList2.Controls.Add(this.lblData2);
            this.groupList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupList2.ForeColor = System.Drawing.Color.Black;
            this.groupList2.Location = new System.Drawing.Point(12, 265);
            this.groupList2.Name = "groupList2";
            this.groupList2.Size = new System.Drawing.Size(759, 186);
            this.groupList2.TabIndex = 7;
            this.groupList2.TabStop = false;
            this.groupList2.Text = "List of Sub Categories";
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.BackColor = System.Drawing.Color.Navy;
            this.btnRefresh2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh2.ForeColor = System.Drawing.Color.White;
            this.btnRefresh2.Location = new System.Drawing.Point(399, 143);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh2.TabIndex = 14;
            this.btnRefresh2.Text = "REFRESH";
            this.btnRefresh2.UseVisualStyleBackColor = false;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.Navy;
            this.btnSearch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.ForeColor = System.Drawing.Color.White;
            this.btnSearch2.Location = new System.Drawing.Point(24, 143);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(75, 23);
            this.btnSearch2.TabIndex = 10;
            this.btnSearch2.Text = "SEARCH";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch2.Location = new System.Drawing.Point(105, 145);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(288, 20);
            this.txtSearch2.TabIndex = 9;
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.Color.Navy;
            this.btnAdd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.ForeColor = System.Drawing.Color.White;
            this.btnAdd2.Location = new System.Drawing.Point(481, 143);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 8;
            this.btnAdd2.Text = "ADD";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.Navy;
            this.btnDelete2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete2.ForeColor = System.Drawing.Color.White;
            this.btnDelete2.Location = new System.Drawing.Point(643, 143);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(97, 23);
            this.btnDelete2.TabIndex = 7;
            this.btnDelete2.Text = "DEACTIVATE";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnEdit2
            // 
            this.btnEdit2.BackColor = System.Drawing.Color.Navy;
            this.btnEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit2.ForeColor = System.Drawing.Color.White;
            this.btnEdit2.Location = new System.Drawing.Point(562, 143);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(75, 23);
            this.btnEdit2.TabIndex = 6;
            this.btnEdit2.Text = "EDIT";
            this.btnEdit2.UseVisualStyleBackColor = false;
            this.btnEdit2.Click += new System.EventHandler(this.btnEdit2_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(24, 32);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(716, 105);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Click += new System.EventHandler(this.listView2_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 192;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 186;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Main Category";
            this.columnHeader4.Width = 197;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 136;
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.BackColor = System.Drawing.Color.Transparent;
            this.lblData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData2.Location = new System.Drawing.Point(687, 14);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(53, 15);
            this.lblData2.TabIndex = 2;
            this.lblData2.Text = "Data: 0";
            // 
            // frmViewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PRJCLUMS.Properties.Resources.Simple_and_elegant_abstract_Wallpaper_HD_2560x1440;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 463);
            this.Controls.Add(this.groupList2);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewCategory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyril\'s Garden Plant & Flower Shop Sales Management System";
            this.Load += new System.EventHandler(this.frmViewCategory_Load);
            this.groupList.ResumeLayout(false);
            this.groupList.PerformLayout();
            this.groupList2.ResumeLayout(false);
            this.groupList2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader CName;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader CDesc;
        private System.Windows.Forms.ColumnHeader CStat;
        private System.Windows.Forms.GroupBox groupList2;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblData2;
    }
}