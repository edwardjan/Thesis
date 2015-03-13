using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PRJCLUMS.Logger;

namespace PRJCLUMS
{
    public partial class frmAddCategory : Form
    {
        CDBProvider cdb = new CDBProvider();
        private int ID;
        private string Name;
        private string Desc;
        private string Stat;
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Logger.Logger.Log("Closing add category form.");
                this.Close();
            }
            catch(Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void ClearTxt()
        {
            txtName.Clear();
            txtDesc.Clear();
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("SAVE"))
            {
                ClearTxt();
            }
            else
            {
                LoadData(ID, Name, Desc, Stat);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Logger.Log("Saving new category data.");
                if (btnSave.Text.Equals("SAVE"))
                {
                    string name = txtName.Text;
                    string desc = txtDesc.Text;
                    if (string.IsNullOrWhiteSpace(desc) || string.IsNullOrWhiteSpace(name))
                    {
                        MessageBox.Show("Please fill all fields!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblcategory` WHERE Name='" + name + "';");
                        if (compare.Equals("0"))
                        {
                            CCategory cc = new CCategory(ID, name, desc, "Active");
                            cc.Save(false);
                            ClearTxt();
                        }
                        else
                        {
                            MessageBox.Show("A category with a similar name already exists!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    string name = txtName.Text;
                    string desc = txtDesc.Text;
                    if (string.IsNullOrWhiteSpace(desc) || string.IsNullOrWhiteSpace(name))
                    {
                        MessageBox.Show("Please fill all fields!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblcategory` WHERE Name='" + name + "';");
                        if (compare.Equals("0") || name.Equals(Name))
                        {
                            CCategory cc = new CCategory(ID, name, desc, Stat);
                            cc.Save(true);
                            frmViewCategory fvc = new frmViewCategory();
                            fvc.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("A category with a similar name already exists!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        public void LoadData(int ID, string Name, string Desc, string Stat)
        {
            this.ID = ID;
            this.Name = Name;
            this.Desc = Desc;
            this.Stat = Stat;
            btnSave.Text = "UPDATE";
            txtName.Text = Name;
            txtDesc.Text = Desc;
        }
    }
}
