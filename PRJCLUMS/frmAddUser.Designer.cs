namespace PRJCLUMS
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.groupPersonal = new System.Windows.Forms.GroupBox();
            this.rbAdm = new System.Windows.Forms.RadioButton();
            this.rbReg = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.txtRepass = new System.Windows.Forms.TextBox();
            this.lblRepass = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPersonal
            // 
            this.groupPersonal.BackColor = System.Drawing.Color.Transparent;
            this.groupPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupPersonal.Controls.Add(this.rbAdm);
            this.groupPersonal.Controls.Add(this.rbReg);
            this.groupPersonal.Controls.Add(this.lblType);
            this.groupPersonal.Controls.Add(this.txtRepass);
            this.groupPersonal.Controls.Add(this.lblRepass);
            this.groupPersonal.Controls.Add(this.btnCancel);
            this.groupPersonal.Controls.Add(this.txtPass);
            this.groupPersonal.Controls.Add(this.btnSave);
            this.groupPersonal.Controls.Add(this.lblPass);
            this.groupPersonal.Controls.Add(this.txtUser);
            this.groupPersonal.Controls.Add(this.lblUser);
            this.groupPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPersonal.ForeColor = System.Drawing.Color.Black;
            this.groupPersonal.Location = new System.Drawing.Point(12, 50);
            this.groupPersonal.Name = "groupPersonal";
            this.groupPersonal.Size = new System.Drawing.Size(503, 163);
            this.groupPersonal.TabIndex = 17;
            this.groupPersonal.TabStop = false;
            this.groupPersonal.Text = "User Information";
            // 
            // rbAdm
            // 
            this.rbAdm.AutoSize = true;
            this.rbAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdm.Location = new System.Drawing.Point(393, 63);
            this.rbAdm.Name = "rbAdm";
            this.rbAdm.Size = new System.Drawing.Size(97, 19);
            this.rbAdm.TabIndex = 26;
            this.rbAdm.Text = "Administrator";
            this.rbAdm.UseVisualStyleBackColor = true;
            // 
            // rbReg
            // 
            this.rbReg.AutoSize = true;
            this.rbReg.Checked = true;
            this.rbReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReg.Location = new System.Drawing.Point(393, 43);
            this.rbReg.Name = "rbReg";
            this.rbReg.Size = new System.Drawing.Size(69, 19);
            this.rbReg.TabIndex = 25;
            this.rbReg.TabStop = true;
            this.rbReg.Text = "Regular";
            this.rbReg.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblType.Location = new System.Drawing.Point(390, 25);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 15);
            this.lblType.TabIndex = 24;
            this.lblType.Text = "User Type";
            // 
            // txtRepass
            // 
            this.txtRepass.BackColor = System.Drawing.Color.White;
            this.txtRepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRepass.Location = new System.Drawing.Point(19, 124);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.Size = new System.Drawing.Size(365, 20);
            this.txtRepass.TabIndex = 23;
            this.txtRepass.UseSystemPasswordChar = true;
            // 
            // lblRepass
            // 
            this.lblRepass.AutoSize = true;
            this.lblRepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRepass.Location = new System.Drawing.Point(16, 106);
            this.lblRepass.Name = "lblRepass";
            this.lblRepass.Size = new System.Drawing.Size(117, 15);
            this.lblRepass.TabIndex = 22;
            this.lblRepass.Text = "Retype Password";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Navy;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(403, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "CLEAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPass.Location = new System.Drawing.Point(19, 83);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(365, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(403, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPass.Location = new System.Drawing.Point(16, 65);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(69, 15);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUser.Location = new System.Drawing.Point(19, 42);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(365, 20);
            this.txtUser.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUser.Location = new System.Drawing.Point(16, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 15);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(8, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "USER MANAGEMENT";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PRJCLUMS.Properties.Resources.Simple_and_elegant_abstract_Wallpaper_HD_2560x1440;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 229);
            this.Controls.Add(this.groupPersonal);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyril\'s Garden Plant & Flower Shop Sales Management System";
            this.groupPersonal.ResumeLayout(false);
            this.groupPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPersonal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRepass;
        private System.Windows.Forms.Label lblRepass;
        private System.Windows.Forms.RadioButton rbAdm;
        private System.Windows.Forms.RadioButton rbReg;
        private System.Windows.Forms.Label lblType;
    }
}