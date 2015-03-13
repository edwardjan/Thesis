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
    public partial class frmViewUser : Form
    {
        CDBProvider cdb = new CDBProvider();
        private string[] data = new string[5];
        public frmViewUser()
        {
            InitializeComponent();
            string[] data = new string[5];
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmViewUser_Load(object sender, EventArgs e)
        {
            cdb.PopulatePassword(listView, "SELECT * FROM `dbclums`.`tbluser`;");
            cdb.ShowCountData(lblData);
        }

        private void listView_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 5; x++)
            {
                data[x] = listView.FocusedItem.SubItems[x].Text.ToString();
            }
            if (data[4].Equals("Active"))
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
                MessageBox.Show("Please select a user to edit!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmAddUser faa = new frmAddUser();
                faa.LoadData(Convert.ToInt16(data[0]), data[1], data[2], data[3], data[4]);
                this.Close();
                faa.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (data[0] == null)
            {
                MessageBox.Show("Please select a user to deactivate!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnDelete.Text.Equals("DEACTIVATE"))
                {
                    string con = MessageBox.Show("Are you sure you want to deactivate this user?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (con.Equals("Yes"))
                    {
                        if (cdb.ExecuteSql("UPDATE dbclums.tbluser SET Status='Inactive' WHERE(ID=" + data[0] + ");"))
                        {
                            cdb.PopulatePassword(listView, "SELECT * FROM `dbclums`.`tbluser`;");
                            cdb.ShowCountData(lblData);
                            MessageBox.Show("User successfully deactivated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            data = new string[5];
                        }
                        else
                        {
                            MessageBox.Show("Failed to deactivate user!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    string con = MessageBox.Show("Are you sure you want to activate this user?", "CONFIRM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (con.Equals("Yes"))
                    {
                        if (cdb.ExecuteSql("UPDATE dbclums.tbluser SET Status='Active' WHERE(ID=" + data[0] + ");"))
                        {
                            cdb.PopulatePassword(listView, "SELECT * FROM `dbclums`.`tbluser`;");
                            cdb.ShowCountData(lblData);
                            MessageBox.Show("User successfully activated!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            data = new string[5];
                            btnDelete.Text = "DEACTIVATE";
                        }
                        else
                        {
                            MessageBox.Show("Failed to activate user!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cdb.PopulatePassword(listView, "SELECT * FROM `dbclums`.`tbluser` WHERE(Username LIKE'%" + txtSearch.Text + "%');");
                cdb.ShowCountData(lblData);
                int dats = listView.Items.Count;
                if (dats == 0)
                {
                    MessageBox.Show("No data found!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                data = new string[5];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddUser faa = new frmAddUser();
            faa.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cdb.PopulatePassword(listView, "SELECT * FROM `dbclums`.`tbluser`;");
            cdb.ShowCountData(lblData);
            txtSearch.Clear();
            data = new string[9];
        }

    }
}
