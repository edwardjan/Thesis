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
    public partial class frmAddUser : Form
    {
        CDBProvider cdb = new CDBProvider();
        private int ID;
        private string User;
        private string Pass;
        private string Type;
        private string Status = "Active";
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Logger.Logger.Log("Closing add user form.");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void ClearTxt()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtRepass.Clear();
            rbReg.Checked = true;
            txtUser.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("SAVE"))
            {
                ClearTxt();
            }
            else
            {
                LoadData(ID, User, Pass, Type, Status);
                txtRepass.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Saving new user data.");
                if (btnSave.Text.Equals("SAVE"))
                {
                    string user = txtUser.Text;
                    string pass = txtPass.Text;
                    string repass = txtRepass.Text;
                    string type = "Regular";
                    if (rbAdm.Checked)
                    {
                        type = "Administrator";
                    }
                    if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(repass))
                    {
                        MessageBox.Show("Please fill all fields!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tbluser` WHERE Username='" + user + "';");
                        if (compare.Equals("0"))
                        {
                            if (pass.Equals(repass))
                            {
                                User = user;
                                Pass = pass;
                                Type = type;
                                CUser ca = new CUser(ID, user, Encrypt(pass), type, Status);
                                ca.Save(false);
                                ClearTxt();
                            }
                            else
                            {
                                MessageBox.Show("Please retype the password properly!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The username is already in use!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    string user = txtUser.Text;
                    string pass = txtPass.Text;
                    string repass = txtRepass.Text;
                    string type = "Regular";
                    if (rbAdm.Checked)
                    {
                        type = "Administrator";
                    }
                    if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(repass))
                    {
                        MessageBox.Show("Please fill all fields!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tbluser` WHERE Username='" + user + "';");
                        if (compare.Equals("0") || user.Equals(User))
                        {
                            if (pass.Equals(repass))
                            {
                                Logger.Logger.Log(string.Format("User: {0} with current access: {1} has changed to {2} successfully by {3}.", User, Type, type, Logger.Logger.CurrentUser));
                                User = user;
                                Pass = pass;
                                Type = type;
                                CUser ca = new CUser(ID, user, Encrypt(pass), type, Status);
                                ca.Save(true);
                                frmViewUser fv = new frmViewUser();
                                fv.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Please retype the password properly!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The username is already in use!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        public void LoadData(int ID, string User, string Pass, string Type, string Status)
        {
            this.ID = ID;
            this.User = User;
            this.Pass = Pass;
            this.Type = Type;
            this.Status = Status;
            btnSave.Text = "UPDATE";
            txtUser.Text = User;
            //txtUser.Enabled = false;
            txtPass.Text = Pass;
            //txtPass.Enabled = false;
            txtRepass.Text = Pass;
            //txtRepass.Enabled = false;

            rbAdm.Enabled = true;
            rbReg.Checked = true;
            if (Type.Equals("Administrator"))
            {
                rbAdm.Checked = true;

                /*if (User != Logger.Logger.CurrentUser)
                {
                    rbAdm.Enabled = false;
                    rbReg.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                }
                else {
                    txtPass.Enabled = true;
                    txtRepass.Enabled = true;
                }*/
            }
            else
            {
                rbReg.Checked = true;
            }
            this.Show();
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
