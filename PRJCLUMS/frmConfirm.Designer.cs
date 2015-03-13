namespace PRJCLUMS
{
    partial class frmConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirm));
            this.txtPassRe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmCancel = new System.Windows.Forms.Button();
            this.btnConfirmOk = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUsernameConfirm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassRe
            // 
            this.txtPassRe.Location = new System.Drawing.Point(89, 90);
            this.txtPassRe.Name = "txtPassRe";
            this.txtPassRe.Size = new System.Drawing.Size(215, 20);
            this.txtPassRe.TabIndex = 36;
            this.txtPassRe.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Re-type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Please enter new administrator information.";
            // 
            // btnConfirmCancel
            // 
            this.btnConfirmCancel.BackColor = System.Drawing.Color.Navy;
            this.btnConfirmCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCancel.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCancel.Location = new System.Drawing.Point(206, 119);
            this.btnConfirmCancel.Name = "btnConfirmCancel";
            this.btnConfirmCancel.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmCancel.TabIndex = 33;
            this.btnConfirmCancel.Text = "CANCEL";
            this.btnConfirmCancel.UseVisualStyleBackColor = false;
            this.btnConfirmCancel.Click += new System.EventHandler(this.btnConfirmCancel_Click);
            // 
            // btnConfirmOk
            // 
            this.btnConfirmOk.BackColor = System.Drawing.Color.Navy;
            this.btnConfirmOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOk.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOk.Location = new System.Drawing.Point(48, 119);
            this.btnConfirmOk.Name = "btnConfirmOk";
            this.btnConfirmOk.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmOk.TabIndex = 32;
            this.btnConfirmOk.Text = "OK";
            this.btnConfirmOk.UseVisualStyleBackColor = false;
            this.btnConfirmOk.Click += new System.EventHandler(this.btnConfirmOk_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(89, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(215, 20);
            this.txtPass.TabIndex = 31;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConfirm.ForeColor = System.Drawing.Color.White;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(10, 69);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(73, 15);
            this.lblPasswordConfirm.TabIndex = 30;
            this.lblPasswordConfirm.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(89, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(215, 20);
            this.txtUser.TabIndex = 29;
            // 
            // lblUsernameConfirm
            // 
            this.lblUsernameConfirm.AutoSize = true;
            this.lblUsernameConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameConfirm.ForeColor = System.Drawing.Color.White;
            this.lblUsernameConfirm.Location = new System.Drawing.Point(6, 43);
            this.lblUsernameConfirm.Name = "lblUsernameConfirm";
            this.lblUsernameConfirm.Size = new System.Drawing.Size(77, 15);
            this.lblUsernameConfirm.TabIndex = 28;
            this.lblUsernameConfirm.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 32);
            this.panel1.TabIndex = 37;
            // 
            // frmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PRJCLUMS.Properties.Resources.pics1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(328, 151);
            this.ControlBox = false;
            this.Controls.Add(this.txtPassRe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmCancel);
            this.Controls.Add(this.btnConfirmOk);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUsernameConfirm);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassRe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmCancel;
        private System.Windows.Forms.Button btnConfirmOk;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUsernameConfirm;
        private System.Windows.Forms.Panel panel1;
    }
}