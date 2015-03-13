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
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
        }

        private void btnConfirmOk_Click(object sender, EventArgs e)
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
                try
                {
                Logger.Logger.Log("Saving new administrator.");
                    if (txtPassRe.Text.Equals(txtPass.Text))
                    {
                        try
                        {
                            CDBProvider cdb = new CDBProvider();
                            CUser cr = new CUser(0, txtUser.Text, Encrypt(txtPass.Text), "Administrator", "Active");
                            if (cr.Save(false))
                            {
                                frmLogin log = new frmLogin();
                                log.Show();
                                this.Close();
                            }
                        }
                        catch (Exception use)
                        {
                            MessageBox.Show(use.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please retype the correct password!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Logger.Log(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnConfirmCancel_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Close();
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

    }
}
