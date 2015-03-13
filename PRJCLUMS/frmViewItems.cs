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
    public partial class frmViewItems : Form
    {
        CDBProvider cdb = new CDBProvider();
        private string[] data = new string[11];
        public frmViewItems()
        {
            InitializeComponent();
            string[] data = new string[11];
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Logger.Logger.Log("Closing manage items form.");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Logger.Log(ex.Message + ex.StackTrace);
            }
        }

        private void frmViewInventory_Load(object sender, EventArgs e)
        {
            cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblitem`;");
            cdb.ShowCountData(lblData);
        }

        private void listView_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 11; x++)
            {
                data[x] = listView.FocusedItem.SubItems[x].Text.ToString();
            }
            if (data[10].Equals("Active"))
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
            if (data[0] == null)
            {
                MessageBox.Show("Please select an item to edit!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Logger.Logger.Log("Editing item data.");
                    frmAddInventory fas = new frmAddInventory();
                    fas.LoadData(Convert.ToInt16(data[0]), data[1], data[2], data[3], data[4], Convert.ToDouble(data[5]), Convert.ToInt16(data[6]), Convert.ToInt16(data[7]), data[8], data[9], data[10]);
                    this.Close();
                    fas.Show();
                }
                catch (Exception ex)
                {
                    Logger.Logger.Log(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (data[0] == null)
            {
                MessageBox.Show("Please select an item to deactivate!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnDelete.Text.Equals("DEACTIVATE"))
                {
                    string con = MessageBox.Show("Are you sure you want to deactivate this item?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (con.Equals("Yes"))
                    {
                        if (cdb.ExecuteSql("UPDATE dbclums.tblitem SET Status='Inactive' WHERE(ItemNumber=" + data[0] + ");"))
                        {
                            try
                            {
                                Logger.Logger.Log("Deactivating item.");
                                cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblitem`;");
                                cdb.ShowCountData(lblData);
                                MessageBox.Show("Item successfully deactivated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                data = new string[11];
                            }
                            catch (Exception ex)
                            {
                                Logger.Logger.Log(ex.Message + ex.StackTrace);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to deactivate item!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    string con = MessageBox.Show("Are you sure you want to activate this item?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (con.Equals("Yes"))
                    {
                        if (cdb.ExecuteSql("UPDATE dbclums.tblitem SET Status='Active' WHERE(ItemNumber=" + data[0] + ");"))
                        {
                            try
                            {
                                Logger.Logger.Log("Activating item.");
                                cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblitem`;");
                                cdb.ShowCountData(lblData);
                                MessageBox.Show("Item successfully activated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                data = new string[11];
                                btnDelete.Text = "DEACTIVATE";
                            }
                            catch (Exception ex)
                            {
                                Logger.Logger.Log(ex.Message + ex.StackTrace);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to activate item!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblitem` WHERE(ItemName LIKE'%" + txtSearch.Text + "%') OR(Category LIKE'%" + txtSearch.Text + "%');");
                cdb.ShowCountData(lblData);
                int dats = listView.Items.Count;
                if (dats == 0)
                {
                    MessageBox.Show("No data found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                data = new string[11];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CDBProvider cdb = new CDBProvider();
            int tee = Convert.ToInt16(cdb.GetData("SELECT COUNT(*) FROM `dbclums`.`tblsubcategory` WHERE(Status='Active');"));
            if (tee <= 0)
            {
                MessageBox.Show("There are no categories in the database!\nA category must be added into the system first!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                try
                {
                    Logger.Logger.Log("Opening add category form.");
                    frmViewCategory fvc = new frmViewCategory();
                    this.Close();
                    fvc.Show();
                }
                catch (Exception ex)
                {
                    Logger.Logger.Log(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                try
                {
                    Logger.Logger.Log("Opening add item form.");
                    frmAddInventory fas = new frmAddInventory();
                    this.Close();
                    fas.Show();
                }
                catch (Exception ex)
                {
                    Logger.Logger.Log(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblitem`;");
            cdb.ShowCountData(lblData);
            txtSearch.Clear();
            data = new string[11];
        }

        private void btnQuan_Click(object sender, EventArgs e)
        {
            if (data[0] == null)
            {
                MessageBox.Show("Please select an item to add quantity!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string con = MessageBox.Show("Are you sure you want to add this item's quantity?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (con.Equals("Yes"))
                {
                    if (cdb.ExecuteSql("UPDATE dbclums.tblitem SET Stock=" + (Convert.ToInt32(data[6]) + Convert.ToInt32(txtQuan.Text)) + " WHERE(ItemNumber=" + data[0] + ");"))
                    {
                        try
                        {
                            Logger.Logger.Log("Added item quantity.");
                            cdb.Populate(listView, "SELECT * FROM `dbclums`.`tblitem`;");
                            cdb.ShowCountData(lblData);
                            MessageBox.Show("Item successfully added!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            data = new string[11];
                        }
                        catch (Exception ex)
                        {
                            Logger.Logger.Log(ex.Message + ex.StackTrace);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to add item!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
