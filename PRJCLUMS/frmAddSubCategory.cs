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
    public partial class frmAddSubCategory : Form
    {
        CDBProvider cdb = new CDBProvider();
        private int ID;
        private string Name;
        private string Desc;
        private string MainCat;
        private string Stat;
        public frmAddSubCategory()
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
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void ClearTxt()
        {
            txtName.Clear();
            txtDesc.Clear();
            txtName.Focus();
            cbCategory.Text = "           (Select)";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("SAVE"))
            {
                ClearTxt();
            }
            else
            {
                LoadData(ID, Name, Desc, MainCat, Stat);
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
                    string mc = cbCategory.Text;
                    if (string.IsNullOrWhiteSpace(desc) || string.IsNullOrWhiteSpace(name) || mc.Equals("           (Select)"))
                    {
                        MessageBox.Show("Please fill all fields!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblsubcategory` WHERE Name='" + name + "';");
                        if (compare.Equals("0"))
                        {
                            compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblcategory` WHERE Name='" + mc + "';");
                            if (compare.Equals("0"))
                            {
                                MessageBox.Show("Main category does not exists!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                CSubCategory cc = new CSubCategory(ID, name, desc, mc, "Active");
                                cc.Save(false);
                                ClearTxt();
                            }
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
                    string mc = cbCategory.Text;
                    if (string.IsNullOrWhiteSpace(desc) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(mc))
                    {
                        MessageBox.Show("Please fill all fields!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblsubcategory` WHERE Name='" + name + "';");
                        if (compare.Equals("0") || name.Equals(Name))
                        {
                            compare = cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblcategory` WHERE Name='" + mc + "';");
                            if (compare.Equals("0"))
                            {
                                MessageBox.Show("Main category does not exists!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                CSubCategory cc = new CSubCategory(ID, name, desc, mc, Stat);
                                cc.Save(true);
                                frmViewCategory fvc = new frmViewCategory();
                                fvc.Show();
                                this.Close();
                            }
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

        public void LoadData(int ID, string Name, string Desc, string MainCat, string Stat)
        {
            this.ID = ID;
            this.Name = Name;
            this.Desc = Desc;
            this.MainCat = MainCat;
            this.Stat = Stat;
            btnSave.Text = "UPDATE";
            txtName.Text = Name;
            txtDesc.Text = Desc;
            cbCategory.Text = MainCat;
        }

        private void frmAddSubCategory_Load(object sender, EventArgs e)
        {
            int tee = Convert.ToInt16(cdb.GetData("SELECT MAX(ID) FROM `dbclums`.`tblcategory` WHERE(Status='Active');"));
            for (int x = 0; x <= tee; x++)
            {
                string data = cdb.GetData("SELECT Name FROM `dbclums`.`tblcategory` WHERE(ID=" + x + ") AND (Status='Active');");
                if (data != "")
                {
                    cbCategory.Items.Add(data);
                }
            }
        }
    }
}
