using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJCLUMS
{
    public partial class frmViewCategory : Form
    {
        CDBProvider cdb = new CDBProvider();
        private string[] data1 = new string[4];
        private string[] data2 = new string[5];
        public frmViewCategory()
        {
            InitializeComponent();
            string[] data1 = new string[4];
            string[] data2 = new string[5];
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Logger.Logger.Log("Closing manage categories form.");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void frmViewCategory_Load(object sender, EventArgs e)
        {
            cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblcategory`;");
            cdb.ShowCountData(lblData);
            cdb.Populate(listView2, "SELECT * FROM `dbclums`.`tblsubcategory`;");
            cdb.ShowCountData(lblData2);
        }

        private void listView_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 4; x++)
            {
                data1[x] = listView.FocusedItem.SubItems[x].Text.ToString();
            }
            if (data1[3].Equals("Active"))
            {
                btnDelete.Text = "DEACTIVATE";
            }
            else
            {
                btnDelete.Text = "ACTIVATE";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (data1[0] == null)
            {
                MessageBox.Show("Please select a category to edit!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Logger.Logger.Log("Editing category data.");
                    frmAddCategory fac = new frmAddCategory();
                    fac.LoadData(Convert.ToInt16(data1[0]), data1[1], data1[2], data1[3]);
                    this.Close();
                    fac.Show();
                }
                catch (Exception ex)
                {
                    Logger.Logger.Log(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (data1[0] == null)
            {
                MessageBox.Show("Please select a category!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnDelete.Text.Equals("DEACTIVATE"))
                {
                    string con = MessageBox.Show("Are you sure you want to deactivate this category?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (con.Equals("Yes"))
                    {
                        if (cdb.ExecuteSql("UPDATE dbclums.tblcategory SET Status='Inactive' WHERE(ID=" + data1[0] + ");"))
                        {
                            try
                            {
                                Logger.Logger.Log("Deactivating category.");
                                cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblcategory`;");
                                cdb.ShowCountData(lblData);
                                MessageBox.Show("Category successfully deactivated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                data1 = new string[4];
                            }
                            catch (Exception ex)
                            {
                                Logger.Logger.Log(ex.Message + ex.StackTrace);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to deactivate category!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    string con = MessageBox.Show("Are you sure you want to activate this category?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (con.Equals("Yes"))
                    {
                        if (cdb.ExecuteSql("UPDATE dbclums.tblcategory SET Status='Active' WHERE(ID=" + data1[0] + ");"))
                        {
                            try
                            {
                                Logger.Logger.Log("Activating category.");
                                cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblcategory`;");
                                cdb.ShowCountData(lblData);
                                MessageBox.Show("Category successfully activated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                data1 = new string[4];
                                btnDelete.Text = "DEACTIVATE";
                            }
                            catch (Exception ex)
                            {
                                Logger.Logger.Log(ex.Message + ex.StackTrace);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to activate category!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Please enter a search value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblcategory` WHERE(Name LIKE'%" + txtSearch.Text + "%');");
                cdb.ShowCountData(lblData);
                int dats = listView.Items.Count;
                if (dats == 0)
                {
                    MessageBox.Show("No data found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                data1 = new string[4];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                Logger.Logger.Log("Opening add main category form.");
                frmAddCategory fac = new frmAddCategory();
                fac.Show();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblcategory`;");
            cdb.ShowCountData(lblData);
            txtSearch.Clear();
            data1 = new string[4];
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 5; x++)
            {
                data2[x] = listView2.FocusedItem.SubItems[x].Text.ToString();
            }
            if (data2[4].Equals("Active"))
            {
                btnDelete2.Text = "DEACTIVATE";
            }
            else
            {
                btnDelete2.Text = "ACTIVATE";
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            string text = txtSearch2.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Please enter a search value!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cdb.Populate(listView2, "SELECT * FROM `dbclums`.`tblsubcategory` WHERE(Name LIKE'%" + txtSearch2.Text + "%');");
                cdb.ShowCountData(lblData2);
                int dats = listView2.Items.Count;
                if (dats == 0)
                {
                    MessageBox.Show("No data found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                data2 = new string[5];
            }
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            cdb.Populate(listView2, "SELECT * FROM `dbclums`.`tblsubcategory`;");
            cdb.ShowCountData(lblData2);
            txtSearch2.Clear();
            data2 = new string[5];
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                Logger.Logger.Log("Opening add sub category form.");
                frmAddSubCategory fas = new frmAddSubCategory();
                fas.Show();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            if (data2[0] == null)
            {
                MessageBox.Show("Please select a category to edit!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Logger.Logger.Log("Editing category data.");
                    frmAddSubCategory fas = new frmAddSubCategory();
                    fas.LoadData(Convert.ToInt16(data2[0]), data2[1], data2[2], data2[3], data2[4]);
                    this.Close();
                    fas.Show();
                }
                catch (Exception ex)
                {
                    Logger.Logger.Log(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (data2[0] == null)
            {
                MessageBox.Show("Please select a category!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnDelete2.Text.Equals("DEACTIVATE"))
                {
                    string con = MessageBox.Show("Are you sure you want to deactivate this category?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (con.Equals("Yes"))
                    {
                        if (cdb.ExecuteSql("UPDATE dbclums.tblsubcategory SET Status='Inactive' WHERE(ID=" + data2[0] + ");"))
                        {
                            try
                            {
                                Logger.Logger.Log("Deactivating category.");
                                cdb.Populate(listView2, "SELECT * FROM `dbclums`.`tblsubcategory`;");
                                cdb.ShowCountData(lblData2);
                                MessageBox.Show("Category successfully deactivated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                data2 = new string[5];
                            }
                            catch (Exception ex)
                            {
                                Logger.Logger.Log(ex.Message + ex.StackTrace);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to deactivate category!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    string con = MessageBox.Show("Are you sure you want to activate this category?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (con.Equals("Yes"))
                    {
                        if (cdb.ExecuteSql("UPDATE dbclums.tblsubcategory SET Status='Active' WHERE(ID=" + data2[0] + ");"))
                        {
                            try
                            {
                                Logger.Logger.Log("Activating category.");
                                cdb.Populate(listView2, "SELECT * FROM `dbclums`.`tblsubcategory`;");
                                cdb.ShowCountData(lblData2);
                                MessageBox.Show("Category successfully activated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                data2 = new string[5];
                                btnDelete2.Text = "DEACTIVATE";
                            }
                            catch (Exception ex)
                            {
                                Logger.Logger.Log(ex.Message + ex.StackTrace);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to activate category!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

    }
}
