using System;
using System.IO;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace PRJCLUMS
{
    public partial class frmLogin : Form
    {
        CDBProvider cdb = new CDBProvider();
        public frmLogin()
        {
            InitializeComponent();
            String haha = cdb.GetData("SELECT * FROM `dbclums`.`tbluser`;");
            if (haha.Equals(""))
            {
                btnLogin.Text = "NEW USER";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log(string.Format("Exiting application from account [{0}] successfully.", txtUser.Text));
                Application.Exit();
            }
            catch (Exception ex) {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnLogin.Text.Equals("LOGIN"))
                {
                    if (string.IsNullOrWhiteSpace(txtUser.Text) && string.IsNullOrWhiteSpace(txtPass.Text))
                    {
                        MessageBox.Show("Please enter a username and password!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrWhiteSpace(txtUser.Text))
                    {
                        MessageBox.Show("Please enter a username!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrWhiteSpace(txtPass.Text))
                    {
                        MessageBox.Show("Please enter a password!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cdb.LogInUser(txtUser.Text, Encrypt(txtPass.Text)))
                        {
                            Logger.Logger.Log(string.Format("Logged in as [{0}].", txtUser.Text));
                            string type = cdb.GetData("SELECT Usertype FROM `dbclums`.`tbluser` WHERE(Username='" + txtUser.Text + "' AND Password='" + Encrypt(txtPass.Text) + "');");
                            frmMDI mdi = new frmMDI();
                            Logger.Logger.CurrentUser = txtUser.Text;
                            mdi.setAdmin(txtUser.Text + " (" + type + ")");
                            mdi.setType(type);
                            mdi.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid user!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    frmConfirm conf = new frmConfirm();
                    conf.Show();
                    this.Hide();
                }
            }
            catch (Exception ex) {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btnLogin_Click(sender, new KeyPressEventArgs('\r'));
        }
    }
}
